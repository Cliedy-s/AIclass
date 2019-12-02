﻿using System;
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
    public partial class Offerer_Form : Form
    {
        public Offerer_Form()
        {
            InitializeComponent();
        }
        private void Offerer_Form_Load(object sender, EventArgs e)
        {
            //제조사 그리드뷰
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvOfferer, "코드", "", true, 60); //제조사코드
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvOfferer, "이름", "", true, 60); //제조사이름
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvOfferer, "번호", "", true, 60); //제조사전화번호      
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvOfferer, "주소", "", true, 60); //제조사주소
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvOfferer, "담당자", "", true, 60); //담당자이름

            //제품 그리드뷰
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvProduct, "코드", "", true, 60); //제조사이름
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvProduct, "자제명", "", true, 60); //제조사전화번호      
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvProduct, "자제타입", "", true, 60); //제조사주소
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvProduct, "개수", "", true, 60); //담당자이름
            DatagridviewDeignes.AddNewColumnToDataGridView(dgvProduct, "가격", "", true, 60); //담당자이름
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
            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count) {

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

            if(e.RowIndex>-1 && e.RowIndex < dt.Rows.Count)
            {
                dt.Rows[e.RowIndex][""].ToString();

                lblCode.Text = "";
                cbbOffererName.Text = "";
                lblProducName.Text= "";
                lblProductMoney.Text= "";
                cbbProductType.Text= "";
                                   
                if (cbbProductType.Text=="반자재") 
                {

                    lblType.Text = "L";

                }
                else
                {
                    lblType.Text = "개";
                }
                lblProductNumber.Text= "";
            }
        }
    }
}
