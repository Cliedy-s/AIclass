using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class Offerer_Form : Form
    {
        List<OffererVO> offerlist;
        List<MaterialsVO> Materlist;
        public Offerer_Form()
        {
            InitializeComponent();
        }
        private void Offerer_Form_Load(object sender, EventArgs e)
        {
            //제조사 그리드뷰
            DatagridviewDeigns.SetDesign(dgvOfferer);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvOfferer, "코드", "off_No", true, 60); //제조사코드
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvOfferer, "이름", "off_Name", true, 60); //제조사이름
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvOfferer, "번호", "off_OwnerMobile", true, 60); //제조사전화번호      
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvOfferer, "주소", "off_Addr", true, 60); //제조사주소
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvOfferer, "담당자", "off_Manager", true, 60); //담당자이름

            //제품 그리드뷰
            DatagridviewDeigns.SetDesign(dgvProduct);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvProduct, "코드", "mat_No", true, 60); //제조사이름
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvProduct, "자제명", "mat_Name", true, 60); //제조사전화번호      
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvProduct, "자제타입", "mtt_Name", true, 60); //제조사주소
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvProduct, "개수", "mat_Each", true, 60); //담당자이름
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvProduct, "가격", "mat_Cost", true, 60); //담당자이름

            DataLoad();
        }
        private void DataLoad()
        {
            OffererService Oservice = new OffererService();
            offerlist = Oservice.GetAllOffereData();
            dgvOfferer.DataSource = offerlist;

            MaterialsService Mservice = new MaterialsService();
            Materlist = Mservice.SelectAll();
            dgvProduct.DataSource = Materlist;

        }

        /// <summary>
        /// 제품등록버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductDialogue_Form frm = new ProductDialogue_Form();
            frm.Show();
        }

        /// <summary>
        /// 제조사 그리드뷰 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOfferer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvOfferer.DataSource;
            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {

                //dt.Rows[e.RowIndex][""].ToString();

            }

        }
        /// <summary>
        /// 제품 그리드뷰 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvProduct.DataSource;

            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                dt.Rows[e.RowIndex][""].ToString();

                lblCode.Text = "";
                lblOffererName.Text = "";
                lblProducName.Text = "";
                lblProductMoney.Text = "";
                lblProductType.Text = "";

                if (lblProductType.Text == "반자재")
                {

                    lblType.Text = "L";

                }
                else
                {
                    lblType.Text = "개";
                }
                lblProductNumber.Text = "";
            }
        }
    }
}
