using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1018_Licenses
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.ShowDialog();
        }

        private void 라이센스관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseForm frm = new LicenseForm();
            frm.ShowDialog();
        }

        private void 라이센스신청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseRegistryForm frm = new LicenseRegistryForm();
            frm.ShowDialog();
        }
    }
}
