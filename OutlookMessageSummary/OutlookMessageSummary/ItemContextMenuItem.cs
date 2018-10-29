using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

using static OutlookMessageSummary.Utility;

namespace OutlookMessageSummary
{
    [ComVisible(true)]
    public class ItemContextMenuItem : Office.IRibbonExtensibility
    {
        public ItemContextMenuItem() { }

        public void Ribbon_Load(Office.IRibbonUI ribbon) { }

        public string GetCustomUI(string ribbonID) => GetResourceText("OutlookMessageSummary.ItemContextMenuItem.xml");

        public void OnClick(Office.IRibbonControl control)
        {
            try
            {
                OMSAddIn.GenerateSummary();
            }
            catch (FormatException)
            {
                MessageBox.Show("Summary template format is not ok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
