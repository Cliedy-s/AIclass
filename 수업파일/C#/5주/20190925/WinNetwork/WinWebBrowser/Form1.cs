using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip_Click(object sender, EventArgs e)
        {
            ToolStripLabel temp = (ToolStripLabel)sender;
            switch (temp.Text)
            {
                case "홈으로":
                    webBrowser1.GoHome();
                    break;
                case "새로고침":
                    webBrowser1.Refresh();
                    break;
                case "이전":
                    webBrowser1.GoBack();
                    break;
                case "이후":
                    webBrowser1.GoForward();
                    break;
                case "정지":
                    webBrowser1.Stop();
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            webBrowser1.Navigate(toolStripTextBox1.Text);
            Cursor.Current = Cursors.Default;
        }
    }
}
