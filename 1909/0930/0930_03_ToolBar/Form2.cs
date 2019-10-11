using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0930_03_ToolBar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 회원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void 계단식ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 바둑판식ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form3 frm3 = new Form3();

            //if (!this.MdiChildren.Contains(frm3))
            //{
            //    frm3.MdiParent = this;
            //    frm3.Show();
            //}

            bool isOpen = false;
            foreach (var item in this.MdiChildren)
            {
                if (item is Form3)
                {
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                Form3 frm3;
                frm3 = new Form3();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }
    }
}
