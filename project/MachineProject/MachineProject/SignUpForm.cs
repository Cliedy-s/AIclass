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
            Regex idEx = new Regex(Properties.Resources.Regex_idEx); // 5~20자의 영문 소문자, 숫자와 특수기호(_),(-)만 사용 가능합니다.
            Regex pwdEx = new Regex(Properties.Resources.Regex_pwdEx); // 숫자1이상, 영문자1이상, 특수문자 1이상, 최대글자수 9자리 이상
            Regex phoneEx = new Regex(Properties.Resources.Regex_phoneEx); // 000(2~3)-0000(3~4)-0000
            Regex nameEx = new Regex(Properties.Resources.Regex_nameEx); // 영대소문만 | 한글만

            //이메일 아이디
            if (!idEx.IsMatch(txtEmail.Text))
            {
                MessageBox.Show(Properties.Resources.Regex_idEx_msg);
                txtEmail.Focus();
                return;
            }
            //비밀번호
            if (!pwdEx.IsMatch(txtPassword.Text))
            {
                MessageBox.Show(Properties.Resources.Regex_pwdEx_msg);
                txtPassword.Focus();
                return;
            }
            //휴대폰 번호
            if (!(string.IsNullOrEmpty(txtPhone.Text.Trim(' ', '-'))) && !(phoneEx.IsMatch(txtPhone.Text)))
            {
                MessageBox.Show(Properties.Resources.Regex_phoneEx_msg);
                txtPhone.Focus();
                return;
            }
            //이름
            if (!(nameEx.IsMatch(txtName.Text)))
            {
                MessageBox.Show(Properties.Resources.Regex_nameEx_msg);
                txtName.Focus();
                return;
            }
            try
            {
                EmployeesService service = new EmployeesService();
                service.Insert(new DTO.EmployeeDTO()
                {
                    EmployeeID = txtEmployeeID.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    ZipCode = address.Zip,
                    Addr1 = address.Addr1,
                    Addr2 = address.Addr2,
                    Authority = 0b0001
                });
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
            // TODO - 이제 로그인해야지! : 10/29
            this.DialogResult = DialogResult.OK;
        }
    }
}
