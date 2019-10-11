using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1001_02_WinFormPrint
{
    public partial class Form1 : Form
    {
        int i=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void 프린터선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void 용지설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 잘 안씀
            //pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            //if(pageSetupDialog1.ShowDialog() == DialogResult.OK)
            //{

            //}
        }

        private void 프린트미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //MessageBox.Show("Print Begin");
        }

        private void PrintDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //MessageBox.Show("Print End");
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(string.Format("Hello .net Page #{0}", i), new Font("Arial", 35), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
            if (i < 10)
            {
                e.HasMorePages = true;
                i++;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
