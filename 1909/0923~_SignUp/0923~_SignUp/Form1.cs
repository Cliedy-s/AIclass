using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923__SignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            Regex regexID = new Regex(@"^[a-zA-Z0-9]{4,15}$");
            if (regexID.IsMatch(txtID.Text))
            {
                txtID.Focus();
                txtID.SelectAll();
                //lblIDChk.Text = "4~ 15 자리의 영문소문자와 숫자만 가능합니다."; 
                lblIDChk.Visible = true;
            }
            else lblIDChk.Visible = false;
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            Regex regexPassword = new Regex(@"^(?=.*[a-zA-Z])(?=.*[!@#$%^*-+])(?=.*[0-9]).{8,20}$");
            if (regexPassword.IsMatch(txtPassword.Text))
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
                //lblPassWord.Text = "8~ 20자리의 영문 대/소문자, 숫자, 특수문자 조합."; // TODO : Regex
                lblPassWord.Visible = true;
            }
            else lblPassWord.Visible = false;
        } 

        private void TxtPasswordChk_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtPasswordChk.Text)
            {
                txtPasswordChk.Focus();
                txtPasswordChk.SelectAll();
                // lblPassWordChk.Text = "확인을 위해서 재입력 해주세요";
                lblPassWordChk.Visible = true;
            }
            else lblPassWordChk.Visible = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Controls)
            {
                if(item is TextBox)
                {
                    TextBox tb  = item as TextBox;
                    sb.AppendLine(tb.Text);
                }
                if(item is Panel)
                {
                    Panel panel = item as Panel;
                    foreach (var panelItem in panel.Controls)
                    {
                        if(panelItem is RadioButton || panelItem is CheckBox)
                        {
                            Control con = panelItem as Control;
                            con.Text;
                        }
                    }
                    sb.AppendLine();
                }
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
