using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;

namespace OutlookMessageSummary
{
    static class Utility
    {
        static public void IfMissingThrow(object o, string message) {
            if (null == o || (o is string && string.IsNullOrEmpty((string)o)))
            {
                throw new Exception(message);
            }
        }

        static public string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        return resourceReader?.ReadToEnd();
                    }
                }
            }
            return null;
        }

        static public void AppendToFile(string path, string body)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(body);
            }
        }

        static public void HTTPRequest(Uri url, string verb, NameValueCollection headers, bool sendBody, String body)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = verb.ToString();
            headers.AllKeys.ToList().ForEach(y => webrequest.Headers.Add(headers[y], y));
            if (sendBody)
            {
                using (StreamWriter sw = new StreamWriter(webrequest.GetRequestStream()))
                {
                    sw.WriteLine(body);
                }
            }
            var res = webrequest.GetResponse();
        }

    }
}
