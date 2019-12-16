﻿using System.Windows.Forms;
using IceCreamManager.VO;
using IceCreamManager.Service;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace IceCreamManager
{
    public partial class OffererOderDialogue : Form
    {
       
        List<OrderSubVO> Sublist; //자재번호 자재이름,제조사번호 제조사이름 

        public OffererOderDialogue()
        {
            InitializeComponent();
        }

        private void OffererOderDialogue_Load(object sender, System.EventArgs e)
        {
            DatagridviewDesigns.SetDesign(dgvOrder);


            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOrder, "발주개수", "", true, 120); //제조사이름
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOrder, "발주자재코드", "", true, 100); //제조사전화번호      
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOrder, "제조사코드", "", true, 80); //담당자이름
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOrder, "주문타입코드", "", true, 300); //제조사주소
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOrder, "발주가격", "", true, 300); //제조사주소
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOrder, "발주날짜", "", true, 300); //제조사주소



            //this.Controls.Add(dgvOrder);
            //dgvOrder.ColumnCount = 7;
            //dgvOrder.Columns[0].Name = "발주코드";
            //dgvOrder.Columns[1].Name = "발주개수";
            //dgvOrder.Columns[2].Name = "발주자재코드";
            //dgvOrder.Columns[3].Name = "제조사코드";
            //dgvOrder.Columns[4].Name = "주문타입코드";
            //dgvOrder.Columns[5].Name = "발주가격";
            //dgvOrder.Columns[6].Name = "발주날짜";


            DataLoad();

            Dictionary<string, int> mnlist = Sublist.ToDictionary(item => item.mat_Name, item => item.mat_No);
            cbbMaerialsName.DisplayMember = "Key";
            cbbMaerialsName.ValueMember = "Value";
            cbbMaerialsName.DataSource = new BindingSource(mnlist, null);

            lbldata.Text = DateTime.Now.ToShortDateString();
            int price = Sublist.Find(item => item.mat_No == Convert.ToInt32(cbbMaerialsName.SelectedValue)).mat_Cost;

            int sum = Convert.ToInt32(nudEach.Value) * price;
            txtprice.Text = sum.ToString();


        }

        private void DataLoad()
        {
            OrderService service = new OrderService();

            (_, Sublist) = service.SelectAll();

        }
        /// <summary>
        /// 자재명선택시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbMaerialsName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtMaterialsCode.Text = Sublist.Find(item => item.mat_No == Convert.ToInt32(cbbMaerialsName.SelectedValue)).mat_No.ToString();
            txtOffererName.Text = Sublist.Find(item => item.mat_No == Convert.ToInt32(cbbMaerialsName.SelectedValue)).off_Name.ToString();
        }

        /// <summary>
        /// 개수에따른 가격변동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudEach_ValueChanged(object sender, EventArgs e)
        {
            int price = Sublist.Find(item => item.mat_No == Convert.ToInt32(cbbMaerialsName.SelectedValue)).mat_Cost;

            int sum = Convert.ToInt32(nudEach.Value) * price;
            txtprice.Text = sum.ToString();
        }
        private void nudEach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {

                int price = Sublist.Find(item => item.mat_No == Convert.ToInt32(cbbMaerialsName.SelectedValue)).mat_Cost;

                int sum = Convert.ToInt32(nudEach.Value) * price;
                txtprice.Text = sum.ToString();

            }


        }
        /// <summary>
        /// 자제 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            int offno;
            bool check = false;
            int sumprice = 0;

            foreach (DataGridViewRow row in dgvOrder.Rows)
            {

                if (row.Cells[1].Value.ToString() == cbbMaerialsName.SelectedValue.ToString())
                {
                    row.Cells[0].Value = Convert.ToInt32(row.Cells[0].Value) + Convert.ToInt32(nudEach.Value);
                    row.Cells[4].Value = Convert.ToInt32(row.Cells[4].Value) + Convert.ToInt32(txtprice.Text);
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                offno = Sublist.Find(item => item.mat_No == Convert.ToInt32(cbbMaerialsName.SelectedValue)).off_No;

                dgvOrder.Rows.Add(Convert.ToInt32(nudEach.Value), Convert.ToInt32(cbbMaerialsName.SelectedValue)
                   , offno, 3, Convert.ToInt32(txtprice.Text), lbldata.Text);
                //발주갯수, 자재코드 제조사코드, 주문타입default1, 발주가격, 발주날짜

                     }

            foreach (DataGridViewRow row in dgvOrder.Rows) //총가격
            {
                sumprice = Convert.ToInt32(lblSumPrice.Text) + Convert.ToInt32(row.Cells[4].Value);
                check = true;
            }

            lblSumPrice.Text = sumprice.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {               
         

            OrderService service = new OrderService();
            foreach (DataGridViewRow row in dgvOrder.Rows) //총가격
            {
                OrderVO order = new OrderVO();
                order.ofo_Each =Convert.ToInt32(row.Cells[0].Value);
                order.mat_No = Convert.ToInt32(row.Cells[1].Value);
                order.off_No= Convert.ToInt32(row.Cells[2].Value);
                order.cmt_No= Convert.ToInt32(row.Cells[3].Value);
                order.ofo_Price= Convert.ToInt32(row.Cells[4].Value);
                order.ofo_Date= Convert.ToDateTime(Convert.ToDateTime(row.Cells[5].Value).ToShortDateString());             
                service.Insert(order);
            }       
        }

    
    }
}
