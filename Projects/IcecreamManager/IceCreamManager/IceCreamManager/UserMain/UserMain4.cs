using System;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserMain4 : Form
    {
        public UserMain4()
        {
            InitializeComponent();
        }

        private void UserMain4_Load(object sender, EventArgs e)
        {
            ((UserMain1)this.MdiParent).btnlogout.Visible = true;
            ((UserMain1)this.MdiParent).btnOrderDetails.Visible = true;
            ((UserMain1)this.MdiParent).label2.Visible = true;
            ((UserMain1)this.MdiParent).labName.Visible = true;

            ((UserMain1)this.MdiParent).picWhite3.Visible = false;
            ((UserMain1)this.MdiParent).picblack3.Visible = true;
            ((UserMain1)this.MdiParent).picWhite2.Visible = true;
            ((UserMain1)this.MdiParent).picblack2.Visible = false;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            UserMain3 frm = new UserMain3();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            UserMain5 frm = new UserMain5();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();
        }
    }
}
