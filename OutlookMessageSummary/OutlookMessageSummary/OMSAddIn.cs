using System;
using System.Windows.Forms;
using static OutlookMessageSummary.Utility;
using Office = Microsoft.Office.Core;

namespace OutlookMessageSummary
{
    public partial class OMSAddIn
    {
        static public void GenerateSummary()
        {
            var options = Properties.Settings.Default;
            var item = Globals.OMSAddIn.Application.ActiveExplorer().Selection[1];
            Template template = new Template(item, options.NamedTemplate);
            string body = template.ToString();
            if (string.IsNullOrEmpty(body))
            {
                return;
            }
            if (options.Clipboard)
            {
                Clipboard.SetText(body);
            }
            if (options.MsgDialog)
            {
                MessageBox.Show(body, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (options.FileDialog)
            {
                // Snippet also in OutlookMessageSummary.MailItemSummaryProperties
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.CheckFileExists = false;
                ofd.CheckPathExists = false;
                ofd.ShowDialog();
                AppendToFile(ofd.FileName, body);
            }
            if (options.AppendToFile)
            {
                AppendToFile(options.AppendPath, body);
            }
            if (options.HTTPRequest)
            {
                Template URITemplate = new Template(item, options.HTTPURL.ToString());
                HTTPRequest(new Uri(URITemplate.ToString()), options.HTTPVerb, options.HTTPHeaders, options.HTTPBody, body);
            }
            if (options.CallDLL)
            {
                DLLCall d = new DLLCall(options.DLLPath, options.DLLProc, body);
                d.Call();
            }
        }

        private void InternalStartup()
        {
            Globals.OMSAddIn.Application.OptionsPagesAdd +=
                x => x.Add(new MailItemSummaryProperties(), "Mail Item Summary Properties");
        }

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new ItemContextMenuItem();
        }
    }
}
