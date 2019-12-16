﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IceCreamManager.Service;
using IceCreamManager.VO;
namespace IceCreamManager
{
    public partial class Salescheck_Form : Form
    {
   
        public Salescheck_Form()
        {
            InitializeComponent();
        }

        private void Salescheck_Form_Load(object sender, EventArgs e)
        {
         
            cbbChoice.Items.Add("제품전체");
            cbbChoice.Items.Add("회원별"); 
            cbbChoice.Items.Add("제품별");
            cbbChoice.Text = "제품전체";
            DatagridviewDesigns.SetDesign(dataGridView1);
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "고객코드", "cus_No", true, 150); //제조사주소
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "이름", "cus_Name", true, 150); //제조사주소
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "제품코드", "pro_No", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "제품이름", "pro_Name", true, 150); //제조사주소
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "제품개수", "cod_Each", true, 150); //제조사주소
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "가격", "pro_Price", true, 150); //제조사주소
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SalescheckService service = new SalescheckService();
            List<SalescheckMVO> materiallist = new List<SalescheckMVO>(); //제품전체 ,제품별 판매금액
            List<SalescheckCVO> customerlist = new List<SalescheckCVO>(); 
            if (cbbChoice.Text == "제품전체")
            {
                materiallist = service.SelectAllM(dtpStart.Value.ToShortDateString(), dtpEnd.Value.AddDays(1).ToShortDateString(), 1);

                dataGridView1.DataSource = materiallist;



            }
            else if (cbbChoice.Text == "회원별")
            {
                customerlist = service.SelectAllC(dtpStart.Value.ToShortDateString(), dtpEnd.Value.AddDays(1).ToShortDateString());

                dataGridView1.DataSource = customerlist;

            }
            else if (cbbChoice.Text == "제품별")
            {
                materiallist = service.SelectAllM(dtpStart.Value.ToShortDateString(), dtpEnd.Value.AddDays(1).ToShortDateString(), 2);

                dataGridView1.DataSource = materiallist;
                
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void cbbChoice_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // dataGridView1.Columns.Clear();
           // if (cbbChoice.Text=="제품전체"){ 
           // DatagridviewDeigns.SetDesign(dataGridView1);
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품코드", "pro_No", true, 60);
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품이름", "pro_Name", true, 150); //제조사주소
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품개수", "cod_Each", true, 150); //제조사주소
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "가격", "pro_Price", true, 150); //제조사주소
           // }
           //else if (cbbChoice.Text == "제품별")
           // {
           //     DatagridviewDeigns.SetDesign(dataGridView1);
           //     DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품코드", "pro_No", true, 60);
           //     DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품이름", "pro_Name", true, 150); //제조사주소
           //     DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품개수", "cod_Each", true, 150); //제조사주소
           //     DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "가격", "pro_Price", true, 150); //제조사주소
           // }
           // else if(cbbChoice.Text == "회원별")
           // { 

           // DatagridviewDeigns.SetDesign(dataGridView1);
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "고객코드", "cus_No", true, 150); //제조사주소
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "이름", "cus_Name", true, 150); //제조사주소
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품코드", "pro_No", true, 60);
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품이름", "pro_Name", true, 150); //제조사주소
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "제품개수", "cod_Each", true, 150); //제조사주소
           // DatagridviewDeigns.AddNewColumnToDataGridView(dataGridView1, "가격", "pro_Price", true, 150); //제조사주소
           // }
        }
    }
}
