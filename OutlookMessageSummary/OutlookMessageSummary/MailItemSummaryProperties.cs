using System;
using System.Linq;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections.Specialized;

using static OutlookMessageSummary.Utility;

namespace OutlookMessageSummary
{
    [ComVisible(true)]
    public partial class MailItemSummaryProperties : UserControl, Outlook.PropertyPage
    {
        private bool isDirty = false;
        private Outlook.PropertyPageSite PropertyPageSite;

        private Outlook.PropertyPageSite GetPropertyPageSite()
        {
            string assembly = typeof(System.Object).Assembly.CodeBase.Replace("mscorlib.dll", "System.Windows.Forms.dll").Replace("file:///", "");
            string name = AssemblyName.GetAssemblyName(assembly).FullName;
            Type unsafeNativeMethods = Type.GetType(Assembly.CreateQualifiedName(name, "System.Windows.Forms.UnsafeNativeMethods"));
            Type ole = unsafeNativeMethods.GetNestedType("IOleObject");
            MethodInfo m = ole.GetMethod("GetClientSite");
            return (Outlook.PropertyPageSite)(m.Invoke(this, null));
        }

        private string FileDialogPath()
        {
            // Snippet also in OutlookMessageSummary.OMSAddIn
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = false;
            ofd.ShowDialog();
            return ofd.FileName;
        }

        private void SetToDirty()
        {
            isDirty = true;
            if (null == PropertyPageSite)
            {
                PropertyPageSite = GetPropertyPageSite();
            }
            PropertyPageSite.OnStatusChange();
        }

        private void ContentChanged(object sender, EventArgs e)
        {
            SetToDirty();
        }

        private void CheckboxChanged(object sender, EventArgs e)
        {
            SetToDirty();
            AppendButton.Enabled = AppendCheckBox.Checked;
            HTTPVerbTextBox.Enabled = HTTPCheckBox.Checked;
            HTTPURLTextBox.Enabled = HTTPCheckBox.Checked;
            HTTPHeadersTextBox.Enabled = HTTPCheckBox.Checked;
            HTTPBodyCheckBox.Checked = HTTPCheckBox.Checked;
            DLLButton.Enabled = DLLCheckBox.Checked;
            DLLProcTextBox.Enabled = DLLCheckBox.Checked;
        }

        private void AppendButton_Click(object sender, EventArgs e)
        {
            SetToDirty();
            AppendLabel.Text = FileDialogPath();
        }

        private void DLLButton_Click(object sender, EventArgs e)
        {
            SetToDirty();
            DLLLabel.Text = FileDialogPath();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            isDirty = false;

            Properties.Settings x = Properties.Settings.Default;
            TemplateTextBox.Text = x.NamedTemplate;
            AppendLabel.Text = x.AppendPath;
            AppendCheckBox.Checked = x.AppendToFile;
            DLLCheckBox.Checked = x.CallDLL;
            ClipboardCheckBox.Checked = x.Clipboard;
            DLLLabel.Text = x.DLLPath;
            DLLProcTextBox.Text = x.DLLProc;
            FileDialogCheckBox.Checked = x.FileDialog;
            HTTPCheckBox.Checked = x.HTTPRequest;
            HTTPURLTextBox.Text = x.HTTPURL?.ToString() ?? "";
            HTTPVerbTextBox.Text = x.HTTPVerb.ToString();
            HTTPBodyCheckBox.Checked = x.HTTPBody;
            MsgDialogCheckBox.Checked = x.MsgDialog;

            if (null != x.HTTPHeaders)
            {   
                foreach (var key in x.HTTPHeaders.AllKeys)
                {
                    HTTPHeadersTextBox.Text += key + ": " + x.HTTPHeaders[key] + "\r\n";
                }
            }
        }

        public MailItemSummaryProperties()
        {
            InitializeComponent();
        }

        public void GetPageInfo(ref string HelpFile, ref int HelpContext) { }

        public void Apply()
        {
            Properties.Settings x = Properties.Settings.Default;
            try
            {
                x.NamedTemplate = TemplateTextBox.Text;
                x.Clipboard = ClipboardCheckBox.Checked;
                x.MsgDialog = MsgDialogCheckBox.Checked;
                x.FileDialog = FileDialogCheckBox.Checked;

                x.AppendToFile = false;
                if (AppendCheckBox.Checked)
                {
                    IfMissingThrow(AppendLabel.Text, "Choose a file to append to!");
                    x.AppendPath = AppendLabel.Text;
                    x.AppendToFile = true;
                }

                x.CallDLL = false;
                if (DLLCheckBox.Checked)
                {
                    IfMissingThrow(DLLLabel.Text, "Choose a DLL to call!");
                    IfMissingThrow(DLLProcTextBox.Text, "Specify a function/method to call!");
                    x.DLLPath = DLLLabel.Text;
                    x.DLLProc = DLLProcTextBox.Text;
                    x.CallDLL = true;
                }

                x.HTTPRequest = false;
                if (HTTPCheckBox.Checked)
                {
                    x.HTTPURL = new Uri(HTTPURLTextBox.Text);
                    x.HTTPVerb = HTTPVerbTextBox.Text;
                    x.HTTPBody = HTTPBodyCheckBox.Checked;
                    var y = new NameValueCollection();
                    foreach (var header in HTTPHeadersTextBox.Text.Replace("\r", "").Split('\n'))
                    {
                        var h = header.Split(':');
                        if (1 < h.Count())
                        {
                            y.Add(h[0].Trim(), h[1].Trim());
                        }
                    }
                    x.HTTPHeaders = y;
                    x.HTTPRequest = true;
                }

                x.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                AppendCheckBox.Checked = x.AppendToFile;
                DLLCheckBox.Checked = x.CallDLL;
                HTTPCheckBox.Checked = x.HTTPRequest;
            }
        }

        bool Outlook.PropertyPage.Dirty
        {
            get
            {
                return isDirty;
            }
        }
    }
}
