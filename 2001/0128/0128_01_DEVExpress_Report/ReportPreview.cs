using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0128_01_DEVExpress_Report
{
    public partial class ReportPreview : Form
    {
        public ReportPreview(Report rpt)
        {
            InitializeComponent();
            using (ReportPrintTool printtool = new ReportPrintTool(rpt))
            {
                printtool.ShowRibbonPreviewDialog();
            }
        }
    }
}
