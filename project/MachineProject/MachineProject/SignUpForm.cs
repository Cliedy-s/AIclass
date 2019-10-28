using RecursiveForChangeControls_MachineProject;
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

namespace MachineProject
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            RecursiveForChangeControls rcontrols = new RecursiveForChangeControls();
            rcontrols.ChangeControls(this.Controls, GlobalUsage.ChangeFont);


        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Regex pwdEx = new Regex(@"^(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"); // 숫자1이상, 영문자1이상, 특수문자 1이상, 최대글자수 9자리 이상
            Regex idEx = new Regex(@"^[a-zA-Z0-9_-]{5,20}$"); // 5~20자의 영문 소문자, 숫자와 특수기호(_),(-)만 사용 가능합니다.
            Regex phoneEx = new Regex(@"^[0-9]{2,3}-[0-9]{3,4}-[0-9]{4}$"); // 000(2~3)-0000(3~4)-0000
            Regex nameEx = new Regex(@"^[A-Za-z0-9가-힣]$"); // 영대소문자 or 한글포함
            // TODO - nameEx 상태 안좋음

            if (!idEx.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("5~20자의 영문 소문자, 숫자와 특수기호(_),(-)만 사용 가능합니다.");
                txtEmail.Focus();
                return;
            }
            if (!pwdEx.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("비밀번호는 숫자1이상, 영문자1이상, 특수문자 1이상, 글자수 8자리 이상입니다.");
                txtPassword.Focus();
                return;
            }
            if (!(string.IsNullOrEmpty(txtPhone.Text.Trim(' ', '-'))) && !(phoneEx.IsMatch(txtPhone.Text)))
            {
                MessageBox.Show("휴대폰 번호를 확인해주세요");
                txtPhone.Focus();
                return;
            }
            if (!(nameEx.IsMatch(txtName.Text)))
            {
                MessageBox.Show("이름을 확인해주세요");
                txtName.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
