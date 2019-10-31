using MachineProject.DTO;
using RecursiveForChangeControls_MachineProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject
{
    public partial class LoginForm : Form
    {
        public string ID { get => txtID.Text; }
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            RecursiveForChangeControls rcontrols = new RecursiveForChangeControls();
            rcontrols.ChangeControls(this.Controls, GlobalUsage.ChangeFont);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            EmployeesService service = new EmployeesService();
            try
            {
                GlobalUsage.MyInfo = service.Login(txtID.Text.Trim(), txtPWD.Text.Trim());
                service.Dispose();
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ee)
            {
                service.Dispose();
                MessageBox.Show(ee.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm frm = new SignUpForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                txtID.Text = frm.Email;
                txtPWD.Text = frm.Password;
                btnLogin.PerformClick();
            }
        }

        private void LnkIDPWDSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IdPwdSearchForm frm = new IdPwdSearchForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void TxtPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
