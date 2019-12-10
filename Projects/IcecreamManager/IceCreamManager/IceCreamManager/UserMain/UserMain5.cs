using System;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserMain5 : Form
    {
        public UserMain5()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void UserMain5_Load(object sender, EventArgs e)
        {
            ((UserMain1)this.MdiParent).btnlogout.Visible = true;
            ((UserMain1)this.MdiParent).btnOrderDetails.Visible = true;
            ((UserMain1)this.MdiParent).label2.Visible = true;
            ((UserMain1)this.MdiParent).labName.Visible = true;

            ((UserMain1)this.MdiParent).picWhite4.Visible = false;
            ((UserMain1)this.MdiParent).picblack4.Visible = true;
            ((UserMain1)this.MdiParent).picWhite3.Visible = true;
            ((UserMain1)this.MdiParent).picblack3.Visible = false;
        }
    }
}
