using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
