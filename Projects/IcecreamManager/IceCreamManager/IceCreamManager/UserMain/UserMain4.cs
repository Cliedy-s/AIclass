﻿using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserMain4 : Form
    {
        public List<CustomerOrderDetailProductConnectVO> DetailList { get; set;  }
        public int Allprice { get; set; }

        public UserMain4()
        {
            InitializeComponent();
        }

        

        private void UserMain4_Load(object sender, EventArgs e)
        {
            #region 환경
            ((UserMain1)this.MdiParent).btnlogout.Visible = true;
            ((UserMain1)this.MdiParent).btnOrderDetails.Visible = true;
            ((UserMain1)this.MdiParent).label2.Visible = true;
            ((UserMain1)this.MdiParent).labName.Visible = true;

            ((UserMain1)this.MdiParent).picWhite3.Visible = false;
            ((UserMain1)this.MdiParent).picblack3.Visible = true;
            ((UserMain1)this.MdiParent).picWhite2.Visible = true;
            ((UserMain1)this.MdiParent).picblack2.Visible = false;
            #endregion

            DatagridviewDesigns.InitSettingDridView(dataGridView1);

            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "아이스크림 이름", "pro_Name", true, 300);
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "사이즈", "pro_SizeString", true, 150);
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "개수", "cod_Each", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "가격", "cod_Price", true, 150);
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "삭제";
            btn.Text = "삭제";
            btn.Name = "btnDelete";
            btn.Width = 150;
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);


            labmoney.Text = Allprice.ToString();
            dataGridView1.DataSource = null;
           
            dataGridView1.DataSource = DetailList;
            //cboCategory.SelectedIndex = 0;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            UserMain2 frm = new UserMain2();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            ((UserMain1)this.MdiParent).picWhite3.Visible = true;
            ((UserMain1)this.MdiParent).picblack3.Visible = false;
            frm.Show();
            this.Close();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerOrderVO order = new CustomerOrderVO();
                order.cus_No = Global.Cus_No;
                order.cuo_Datetime = DateTime.Now;
                order.cuo_TotalPrice = Allprice;

                UserService service = new UserService();
                bool bResult = service.RegisterOrder(order, DetailList);
                if (bResult)
                {
                    MessageBox.Show("주문이 완료 되었습니다");

                    #region 다음폼이동
                    UserMain5 frm = new UserMain5();
                    frm.MdiParent = (UserMain1)this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    this.Close();
                    #endregion
                }
                else
                {
                    MessageBox.Show("주문 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("삭제","이건 월요일날 ^^");
        }
    }
}
