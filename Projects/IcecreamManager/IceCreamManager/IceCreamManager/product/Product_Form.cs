﻿using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class Product_Form : Form
    {

        List<ProductMaterialConnectVO> Plist;
        public Product_Form()
        {
            InitializeComponent();
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductDialog_Form frm = new ProductDialog_Form();
            frm.ShowDialog();
            DataLoad();
        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            DatagridviewDesigns.SetDesign(dgvProduct);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "상품코드", "pro_No", true, 60); 
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "상품이름", "pro_Name", true, 60, default, true); 
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "상품개수", "mat_Each", true, 150); 
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "자재타입", "mtt_Name", true, 150); 
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "상품가격", "pro_Price", true, 150); 
            //DatagridviewDeigns.AddNewColumnToDataGridView(dgvProduct, "이미지", "", true, 150); 
            DataLoad();
        }
        private void DataLoad()
        {
            ProductService service = new ProductService();
            Plist= service.SelectAllProductMaterialConnect();
            dgvProduct.DataSource = Plist;
        }
    }
}
