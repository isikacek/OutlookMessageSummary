using System;
using System.Reflection;
using System.Runtime.InteropServices;

using static OutlookMessageSummary.Utility;

namespace OutlookMessageSummary
{
    class DLLCall
    {
        static private class NativeMethods
        {
            [DllImport("kernel32.dll")]
            public static extern IntPtr LoadLibrary(string dll);
            [DllImport("kernel32.dll")]
            public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);
            [DllImport("kernel32.dll")]
            public static extern bool FreeLibrary(IntPtr hModule);
        }

        private struct FullName
        {
            public string Class;
            public string Method;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void UnmanagedCallback(string body);
        private string Path;
        private string Identifier;
        private string Body;


        private FullName SplitFullPathFrom(string fullName)
        {
            int idx = fullName.LastIndexOf('.');
            if (idx < 0)
            {
                throw new Exception("Bad format: managed dlls need to be in namespace.class format!");
            }
            return new FullName {
                Class = fullName.Substring(0, idx),
                Method = fullName.Substring(idx + 1)
            };
        }

        private void CallManaged()
        {
            Assembly assembly = Assembly.LoadFrom(Path);
            var x = SplitFullPathFrom(Identifier);
            Type type = assembly.GetType(x.Class);
            object o = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod(x.Method);
            method.Invoke(o, new object[] { Body });
        }

        private void CallUnamanged()
        {
            IntPtr dll = NativeMethods.LoadLibrary(Path);
            if (dll == IntPtr.Zero)
            {
                throw new Exception("Can't open DLL file!");
            }
            IntPtr procAddr = NativeMethods.GetProcAddress(dll, Identifier);
            if (procAddr == IntPtr.Zero)
            {
                throw new Exception("Can't find " + Identifier + " in DLL!");
            }
            UnmanagedCallback callback = (UnmanagedCallback)
                Marshal.GetDelegateForFunctionPointer(procAddr, typeof(UnmanagedCallback));
            callback(Body);
            NativeMethods.FreeLibrary(dll);
        }

        public DLLCall(string path, string identifier, string body)
        {
            IfMissingThrow(path, "Please specify dll path!");
            IfMissingThrow(identifier, "Please specify dll call!");
            Path = path;
            Identifier = identifier;
            Body = body ?? "";
        }

        public void Call()
        {
            // MS recomended way to figure out if dll is managed or not :)
            try
            {
                CallManaged();
            }
            catch (Exception)
            {
                CallUnamanged();
            }
        }
    }
}
