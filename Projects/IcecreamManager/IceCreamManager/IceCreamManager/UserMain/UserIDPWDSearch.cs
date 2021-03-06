﻿using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserIDPWDSearch : Form
    {
        string resident_emailCheck = string.Empty;
        
        public UserIDPWDSearch()
        {
            InitializeComponent();
        }

        private void BtnIdsearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                UserInfoVO uvo = new UserInfoVO();
                uvo.cus_Name = txtIDSearchName.Text.Trim();
                uvo.cus_Phone = txtIDSearchPhone.Text.Trim();
                uvo.cus_Email = txtIDSearchEamil.Text.Trim();
                
                UserService service = new UserService();
                resident_emailCheck = service.UserIDSearch(uvo);

                if (resident_emailCheck == null)
                {
                    MessageBox.Show("이름 전화번호 이메일을 다시확인하여 주십시오");

                }
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    string newPwd = IDSendMail(txtIDSearchEamil.Text.Trim(), uvo);
                    this.Cursor = Cursors.Default;
                    if (!string.IsNullOrEmpty(newPwd))
                    {

                        MessageBox.Show("아이디를 email로 발송하였습니다. 확인부탁드립니다.");

                    }
                    else
                    {
                        MessageBox.Show("메일발송중 오류가 발생했습니다.");
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }
        }
        private void BtnPWDsearch_Click(object sender, EventArgs e)
        {
            try
            {

                UserInfoVO uvo = new UserInfoVO();
                uvo.cus_ID = txtPWDSearchID.Text.Trim();
                uvo.cus_Phone = txtPWDSearchPhone.Text.Trim();
                uvo.cus_Email = txtPWDSearchEamil.Text.Trim();

                UserService service = new UserService();
                bool UserEmailCheck = service.UserEmailCheck(uvo);

                if (UserEmailCheck == true)
                {
                    MessageBox.Show("아이디와 이메일 전화번호를. 다시확인하여 주십시오");
                    return;
                }
                else
                {
                    string newpwd = CreateNewPassword();
                    uvo.cus_Password = newpwd;
                    if (service.UserPWDUpdate(uvo) > 0)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        string newPwd = PwdSendMail(newpwd, txtPWDSearchEamil.Text.Trim());

                        this.Cursor = Cursors.Default;
                            MessageBox.Show("비밀번호를 email로 발송하였습니다. 확인부탁드립니다.");
                    }
                    else
                    {
                        MessageBox.Show("메일발송중 오류가 발생했습니다.");
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }
        }
        string IDSendMail(string email, UserInfoVO uvo )
        {
            while (true)
            {
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.UseDefaultCredentials = false;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.Credentials = new System.Net.NetworkCredential("tkddls3319@gmail.com", "dls1046315!");

                    MailAddress mailFrom = new MailAddress("" + txtIDSearchEamil.Text + "", "베라관리자", Encoding.UTF8);
                    MailAddress mailTo = new MailAddress(email);
                    MailMessage message = new MailMessage(mailFrom, mailTo);

                    message.Subject = string.Format("{0}님의 아이디  안내 메일입니다.", uvo.cus_Name );


                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("회원 아이디 : {0}\n", resident_emailCheck);

                    message.Body = sb.ToString();
                    message.BodyEncoding = Encoding.UTF8;
                    message.SubjectEncoding = Encoding.UTF8;

                    client.Send(message);
                    message.Dispose();

                    return resident_emailCheck;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.ToString());
                    return null;
                }
            }
        }
        string PwdSendMail(string newPwd, string email )
        {
            while (true)
            {
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.UseDefaultCredentials = false;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.Credentials = new System.Net.NetworkCredential("tkddls3319@gmail.com", "dls1046315!");

                    MailAddress mailFrom = new MailAddress("" + txtPWDSearchEamil.Text + "", "베라관리자", Encoding.UTF8);
                    MailAddress mailTo = new MailAddress(email);
                    MailMessage message = new MailMessage(mailFrom, mailTo);

                    message.Subject = "베라 비밀번호 초기화 안내 메일입니다.";


                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("회원 비밀번호 : {0}\n", newPwd);

                    message.Body = sb.ToString();
                    message.BodyEncoding = Encoding.UTF8;
                    message.SubjectEncoding = Encoding.UTF8;

                    client.Send(message);
                    message.Dispose();

                    return resident_emailCheck;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.ToString());
                    return null;
                }
            }
        }
        string CreateNewPassword()
        {
            Random r = new Random();
            //신규비밀번호 = 랜덤8자리(영문대문자 + 숫자)
            string pwd = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                int rndVal = r.Next(0, 36);
                if (rndVal < 10) //숫자
                {
                    pwd += rndVal;
                }
                else
                {
                    pwd += (char)(rndVal + 55); //65~90 : 영어대문자
                }
            }

            return pwd;
        }


    }
}
