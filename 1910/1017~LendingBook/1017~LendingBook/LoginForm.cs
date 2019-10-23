using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1017_LendingBook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginDB login = new LoginDB();
            bool bCheck = login.LoginCheck(txtUserID.Text.Trim(), txtPWD.Text.Trim());
            if (bCheck)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("로그인 정보가 정확하지 않습니다.", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtUserID.Text = "";
                txtPWD.Text = "";
                txtUserID.Focus();
            }
        }

        public class LoginDB {
            public bool LoginCheck(string id, string password )
            {
                // DB 연결
                // 사용자 존재 체크, admin인지 아닌지도
                // select * from UserTbl where userid = @userid and password = @password; 
                //MySqlDataReader reader = new MySqlDataReader();
                //if (reader.Read())
                //{
                    Global.UserName = null ;
                    Global.g_userID = "admin";
                    return true;
                //}
                //return false;

            }
        }
    }
}
