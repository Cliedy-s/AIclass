using Print_Csharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1002_04_PrintDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextPrintDocument textPrintDocument = new TextPrintDocument(new StringReader(textBox1.Text), textBox1.Font);
            printPreviewDialog1.Document = textPrintDocument;
            printPreviewDialog1.ShowDialog();
        }
    }
}
