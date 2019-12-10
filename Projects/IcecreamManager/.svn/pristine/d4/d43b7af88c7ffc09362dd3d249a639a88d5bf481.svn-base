using IceCreamManager.Service;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class BOM_Amount : Form
    {
        // 엑셀 제일 윗줄 완제품, 아래는 재료들
        public BOM_Amount()
        {
            InitializeComponent();
        }
        private void InitControls()
        { // m.[mat_No], mt.[mtt_No], m.[off_No], m.[mat_Name], m.[mat_Cost], m.[mat_Each], m.[mat_MinSize], m.[mat_Unit], mt.mtt_Name

            DatagridviewDeigns.SetDesign(dgvAmountParent);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountParent, "자재번호", "mat_No", true, 100);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountParent, "자재명", "mat_Name", true, 210, default, true);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountParent, "자재단계", "mtt_Name", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountParent, "자재가격", "mat_Cost", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountParent, "자재갯수", "mat_Each", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountParent, "최소수", "mat_MinSize", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountParent, "단위", "mat_Unit", true, 50);

            DatagridviewDeigns.SetDesign(dgvAmountChild);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountChild, "자재번호", "mat_No", true, 100);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountChild, "자재명", "mat_Name", true, 210, default, true);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountChild, "자재단계", "mtt_Name", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountChild, "자재가격", "mat_Cost", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountChild, "자재갯수", "mat_Each", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountChild, "최소수", "mat_MinSize", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvAmountChild, "단위", "mat_Unit", true, 50);
        }

        private void BtnFind_Click(object sender, System.EventArgs e)
        {
            BOM_AmountSearch frm = new BOM_AmountSearch();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvAmountParent.DataSource = frm.SelectedValues;

                List<int> parentValues = new List<int>();
                foreach (var item in frm.SelectedValues)
                {
                    parentValues.Add(item.mat_No);
                }
                //
                BOMService service = new BOMService();
                dgvAmountChild.DataSource = service.SelectAllChilds(parentValues);
            }
        }

        private void BOM_Amount_Load(object sender, System.EventArgs e)
        {
            InitControls();
        }
    }
}