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
    public partial class Product_Form : Form
    {
        public Product_Form()
        {
            InitializeComponent();
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
           ProductDialog_Form frm = new ProductDialog_Form();
           frm.ShowDialog();
        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "상품이름", "", true, 60); //제조사주소
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "상품개수", "", true, 150); //제조사주소
       
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "자재타입", "", true, 150); //제조사주소
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "상품가격", "", true, 150); //제조사주소
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "이미지", "", true, 150); //제조사주소   
        }
    }
}
