using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            //CommonUtil.FormOpenByString("_1125_ListLinqSampleUI.frmEmployee", this);
        }

        private void 주문관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CommonUtil.FormOpen<Type.GetType("_1125_ListLinqSampleUI.frmOrder")> (this);
            CommonUtil.FormOpen("frmOrder", this);
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
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Debug.WriteLine("Current Doamin Name : " + currentDomain.FriendlyName);
            foreach (Assembly asm in currentDomain.GetAssemblies())
            {
                Debug.WriteLine("  " + asm.FullName);
                foreach (Module module in asm.GetModules())
                {
                    Debug.WriteLine("    " + module.FullyQualifiedName);
                }
            }

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Save?.Invoke(this, null);
        }
    }
}
