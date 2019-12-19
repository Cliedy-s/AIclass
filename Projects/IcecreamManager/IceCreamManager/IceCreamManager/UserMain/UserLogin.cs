﻿using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {          
            Global.Cus_Id = loginID.Text;
            Global.Cus_Password = loginPassword.Text;
            try
            {
                StringBuilder str = new StringBuilder();

            if (loginID.Text.Length == 0)
            {
                str.AppendLine("아이디를 입력해주세요.");
                loginID.Focus();
            }
                if (loginPassword.Text.Length == 0)
            {
                str.AppendLine("비밀번호를 입력해주세요.");
                loginPassword.Focus();
            }
            if (str.ToString() != "")
            {
                MessageBox.Show(str.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginID.Focus();
                    return;
            }

          
                UserInfoVO uif = new UserInfoVO();
                uif.cus_ID = loginID.Text.Trim();
                uif.cus_Password = loginPassword.Text.Trim();

                UserService service1 = new UserService();
                Global.Cus_No = int.Parse(service1.UserCode(uif));
                

                UserService service = new UserService();
                Global.Cus_Name = service.UserName(uif);
                bool? bResult = service.ManagerCheck(uif);
                if (bResult == true)
                {
                    MessageBox.Show(string.Format(" {0}님 환영 합니다. ", Global.Cus_Name),"알림");

                    UserMain2 frm = new UserMain2();
                    frm.MdiParent = (UserMain1)this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ControlBox = false;
                    frm.Show();
                    this.Close();
                }
                else if(bResult == false)
                {
                    MessageBox.Show("매니저님 환영합니다.","알림");
                    loginID.Text = "";
                    loginPassword.Text = "";

                    AdminMain frm = new AdminMain();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show( "아이디나 비밀번호가 일치하지 않습니다.","로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("아이디나 비밀번호가 일치하지 않습니다.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Linkidpwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserIDPWDSearch frm = new UserIDPWDSearch();
            frm.Show();
        }

        private void BtnSigin_Click(object sender, EventArgs e)
        {
            UserJoin frm = new UserJoin();
            frm.Show();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void loginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
             {
                btnlogin.PerformClick();
             }

        }
    }
}
