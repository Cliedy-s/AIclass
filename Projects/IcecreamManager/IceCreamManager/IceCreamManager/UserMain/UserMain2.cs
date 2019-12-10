using System;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserMain2 : Form
    {
        public UserMain2()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            UserMain3 frm = new UserMain3();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void UserMain2_Load(object sender, EventArgs e)
        {
            ((UserMain1)this.MdiParent).btnlogout.Visible = true;
            ((UserMain1)this.MdiParent).btnOrderDetails.Visible = true;
            ((UserMain1)this.MdiParent).label2.Visible = true;
            ((UserMain1)this.MdiParent).labName.Visible = true;

            ((UserMain1)this.MdiParent).picWhite1.Visible = true;
            ((UserMain1)this.MdiParent).picblack1.Visible = false;
            ((UserMain1)this.MdiParent).picWhite2.Visible = false;
            ((UserMain1)this.MdiParent).picblack2.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            labSize.Text = "주니어";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            labSize.Text = "레귤러";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            labSize.Text = "킹";
        }
    }
}
