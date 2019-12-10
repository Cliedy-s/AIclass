using System;
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
            UserMain2 frm = new UserMain2();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.ControlBox = false;

            frm.Show();

            this.Close();
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
    }
}
