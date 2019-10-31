using EmailSend_1030;
using MySql.Data.MySqlClient;
using RandomPassword_1030;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1030_01_IDPWDSearch
{
    public partial class idpwdForm : Form
    {
        string connstr;
        public idpwdForm()
        {
            InitializeComponent();
        }

        private void IdpwdForm_Load(object sender, EventArgs e)
        {
            connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchForPwd(txtEmail.Text.Trim(), txtName.Text.Trim());
            //txtID.Text;
            //txtPWD.Text;
            //txtEmail.Text;
        }

        void SearchForPwd(string email, string name)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connstr);
                string sql = "SELECT Count(*) FROM EMPLOYEES WHERE Name = @Name and Email = @Email; ";
                conn.Open();

                MySqlCommand comm = new MySqlCommand(sql, conn);
                FillParameters(comm, email, name);
                int result = Convert.ToInt32(comm.ExecuteScalar());
                if (result == 0)
                    MessageBox.Show("회원 정보가 일치하지 않습니다. 다시 확인하여 주십시오.");
                else
                {
                    // TODO - 트랜젝션 처리로 묶어주기
                    string newPwd = PasswordSet();

                    if (!string.IsNullOrEmpty(newPwd))
                    {
                        sql = "UPDATE EMPLOYEES SET Password = @newPwd WHERE Email = @Email";
                        comm.CommandText = sql;
                        comm.Parameters.AddWithValue("@newPwd", newPwd);
                        int Affect = comm.ExecuteNonQuery();

                        if (Affect > 0)
                            MessageBox.Show("초기화된 비밀번호를 Email에 발송하였습니다.");
                        else
                            MessageBox.Show("비밀번호 변경 중 오류가 발생했습니다.");
                    }
                    // 여기까지 ------------- 업데이트가 성공이면 메일을 보내기
                    else
                    {
                        MessageBox.Show("메일 발송중 오류가 발생하였습니다");
                    }
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private string PasswordSet()
        {
            EmailSend send = new EmailSend();
            RandomPassword password = new RandomPassword();

            string newPwd = password.CreateNewPassword();
            string email = txtEmail.Text.Trim();
            string title = string.Format("{0}님 비밀번호 초기화 안내 메일입니다.", txtName.Text.Trim());
            string emailFrom = ConfigurationManager.AppSettings["emailSendFrom"];
            string pwdFrom = ConfigurationManager.AppSettings["emailSendAppPassword"];

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("회원 아이디 : {0} \n", email);
            sb.AppendFormat("신규비밀번호 : {0} \n", newPwd);
            string content = sb.ToString();


            send.Send(email, emailFrom, pwdFrom, title, content);
            return newPwd;
        }

        void FillParameters(MySqlCommand comm, string email, string name)
        {
            comm.Parameters.AddWithValue("@Name", name);
            comm.Parameters.AddWithValue("@Email", email);
        }
    }
}
