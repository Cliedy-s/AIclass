﻿using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserMain2 : Form
    {
        
        public UserMain2()
        {
            InitializeComponent();
        }
   
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (labSize.Text != "???")
            {
                foreach (Form childForm in Application.OpenForms)
                {
                    if (childForm is UserMain3)
                    {
                        ((UserMain3)childForm).Pro_Size = labSize.Text;
                        childForm.Activate();
                        this.Close();
                        return;

                    }
                }

                UserMain3 frm = new UserMain3();
                frm.Pro_Size = labSize.Text;
                frm.MdiParent = (UserMain1)this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("사이즈를 선택해주세요","선택");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            #region 다음폼 이동
            UserLogin frm = new UserLogin();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            ((UserMain1)this.MdiParent).picWhite1.Visible = false;
            ((UserMain1)this.MdiParent).picblack1.Visible = true;
            ((UserMain1)this.MdiParent).picWhite2.Visible = true;
            ((UserMain1)this.MdiParent).picblack2.Visible = false;
            ((UserMain1)this.MdiParent).label2.Visible = false;
            ((UserMain1)this.MdiParent).labName.Visible = false;
            ((UserMain1)this.MdiParent).btnlogout.Visible = false;
            ((UserMain1)this.MdiParent).btnOrderDetails.Visible = false;
            ((UserMain1)this.MdiParent).btnPwdChange.Visible = false;

            frm.Show();
            this.Close();
            #endregion
        }

        private void UserMain2_Load(object sender, EventArgs e)
        {
            #region 설정
            ((UserMain1)this.MdiParent).btnPwdChange.Visible = true;
            ((UserMain1)this.MdiParent).labName.Text = Global.Cus_Name;
            ((UserMain1)this.MdiParent).btnlogout.Visible = true;
            ((UserMain1)this.MdiParent).btnOrderDetails.Visible = true;
            ((UserMain1)this.MdiParent).label2.Visible = true;
            ((UserMain1)this.MdiParent).labName.Visible = true;

            ((UserMain1)this.MdiParent).picWhite1.Visible = true;
            ((UserMain1)this.MdiParent).picblack1.Visible = false;
            ((UserMain1)this.MdiParent).picWhite2.Visible = false;
            ((UserMain1)this.MdiParent).picblack2.Visible = true;
            #endregion
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            labSize.Text = "주니어";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            labSize.Text = "레귤러";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            labSize.Text = "킹";
        }
    }
}
