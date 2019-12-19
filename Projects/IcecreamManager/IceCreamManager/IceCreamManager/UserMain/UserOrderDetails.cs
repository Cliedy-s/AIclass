﻿using IceCreamManager.DAC;
using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserOrderDetails : Form
    {
        public UserOrderDetails()
        {
            InitializeComponent();
        }
        CustomerOrderService coservice;
        CustomerOrderDetailService codservice;
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UserOrderDetails_Load(object sender, EventArgs e)
        {
            codservice = new CustomerOrderDetailService();
            coservice = new CustomerOrderService();
            InitControls();
            DataLoad();

            btnSearch.PerformClick();
        }
        private void InitControls()
        {
            DateTime now = DateTime.Now;
            dtpTo.Value = now;
            dtpFrom.Value = now.AddDays(-7);

            DatagridviewDesigns.SetDesign(dgvCustomerOrder);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrder, "주문번호", "cuo_No", true, 120);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrder, "고객번호", "cus_No", false, 210);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrder, "주문날짜", "cuo_Datetime", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrder, "주문총가격", "cuo_TotalPrice", true, 100);

            DatagridviewDesigns.SetDesign(dgvCustomerOrderDetail);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrderDetail, "주문상세번호", "cod_No", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrderDetail, "제품번호", "pro_No", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrderDetail, "제품이름", "pro_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrderDetail, "주문갯수", "cod_Each", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrderDetail, "제품가격", "pro_Price", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrderDetail, "사이즈", "cod_SizeString", true, 70);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrderDetail, "총가격", "Unbound",true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCustomerOrderDetail, "사이즈", "cod_Size", false, 70);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCustomerOrder.DataSource = coservice.SelectAll(Global.Cus_No, dtpFrom.Value, dtpTo.Value.AddDays(1));
        }
        private void DataLoad()
        {
            dgvCustomerOrder.DataSource = coservice.SelectAll(Global.Cus_No, dtpFrom.Value, dtpTo.Value.AddDays(1));
        }
        private void dgvCustomerOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCustomerOrderDetail.DataSource = codservice.SelectAllJoinProductName(Convert.ToInt32(dgvCustomerOrder.SelectedRows[0].Cells[0].Value));
            OnRowsAdded();
        }
        private void OnRowsAdded()
        {
            for (int i = 0; i < dgvCustomerOrderDetail.RowCount; i++)
            {
                DataGridViewRow row = dgvCustomerOrderDetail.Rows[i];
                row.Cells[6].Value =Convert.ToInt32(row.Cells[4].Value)* Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(row.Cells[7].Value);
            }
        }
    }
}
