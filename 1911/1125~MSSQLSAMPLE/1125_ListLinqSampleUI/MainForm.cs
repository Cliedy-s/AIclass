using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1125_ListLinqSampleUI
{
    public partial class MainForm : Form
    {
        public EventHandler Save;
        public MainForm()
        {
            InitializeComponent();
        }

        private void 사원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)  // 현재 열린 모든 폼
            {
                if (item.GetType() == typeof(frmEmployee))
                {
                    item.Activate(); // 폼 활성화
                    return;
                }
            }
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            //frm.ControlBox = false; // 아이콘과 최소화 최대화 엑스 버튼을 없애줌
            frm.Show();
        }

        private void 주문관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)  // 현재 열린 모든 폼
            {
                if (item.GetType() == typeof(frmOrder))
                {
                    item.Activate();
                    return;
                }
            }
            frmOrder frm = new frmOrder();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        // toolbar merge
        public bool AppendToolStrip(ToolStrip source)
        {
            return ToolStripManager.Merge(source, this.toolStrip1);
        }
        public bool RemoveToolStrip(ToolStrip source)
        {
            return ToolStripManager.RevertMerge(this.toolStrip1, source);
        }
        //

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        { // control box만 안보이게 하기
            if (e.Item.Text == "")
            {
                e.Item.Visible = false;
            }
        }

        private void 창ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Save?.Invoke(this, null);
        }
    }
}
