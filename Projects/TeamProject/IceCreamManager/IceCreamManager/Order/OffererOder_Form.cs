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
    public partial class OffererOder_Form : Form
    {
        public OffererOder_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 발주버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void OffererOder_Form_Load(object sender, EventArgs e)
        {
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "코드", "", true, 150); //제조사코드      
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "제조사이름", "", true, 150); //제조사전화번호      
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "자제이름", "", true, 150); //제조사주소
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "수량", "", true, 150); //제조사주소
            DatagridviewDeignes.AddNewColumnToDataGridView(dataGridView1, "주문 상태", "", true, 150); //담당자이름
        }
    }
}
