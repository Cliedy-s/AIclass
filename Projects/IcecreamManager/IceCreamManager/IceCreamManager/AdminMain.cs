using System;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }
        #region ToolStripMenuItem OpenForm
        private void BOM메인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.FormOpen<BOM_Main>(this);
        }
        private void BOM등록ToolStripMenuItem1(object sender, EventArgs e)
        {
            Helper.FormOpen<BOM_Insert>(this);
        }

        private void 소요량예측ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.FormOpen<BOM_Amount>(this);
        }
        private void 판매예측ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.FormOpen<BOM_Forecast>(this);
        }
        private void 자재목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.FormOpen<Offerer_Form>(this);
        }
        private void 상품목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.FormOpen<Product_Form>(this);
        }
        private void 매출조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.FormOpen<Salescheck_Form>(this);
        }
        private void 발주ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.FormOpen<OffererOder_Form>(this);
        }
        #endregion
        private void MenuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "")
            {
                e.Item.Visible = false;
            }
        } // mdi child가 합쳐쳤을 때 아이콘을 지우는 부분


    }
}
