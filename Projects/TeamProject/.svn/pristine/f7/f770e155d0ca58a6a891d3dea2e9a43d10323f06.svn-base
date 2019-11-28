using IceCreamManager.BOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void BOM메인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(BOM_Main))
                {
                    childForm.Activate();
                }
            }
            BOM_Main frm = new BOM_Main();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void BOM등록ToolStripMenuItem1(object sender, EventArgs e)
        {
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(BOM_Insert))
                {
                    childForm.Activate();
                }
            }
            BOM_Insert frm = new BOM_Insert();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void BOM조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(BOM_Search))
                {
                    childForm.Activate();
                }
            }
            BOM_Search frm = new BOM_Search();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 소요량예측ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(BOM_Amount))
                {
                    childForm.Activate();
                }
            }
            BOM_Amount frm = new BOM_Amount();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 판매예측ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(BOM_Forecast))
                {
                    childForm.Activate();
                }
            }
            BOM_Forecast frm = new BOM_Forecast();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
