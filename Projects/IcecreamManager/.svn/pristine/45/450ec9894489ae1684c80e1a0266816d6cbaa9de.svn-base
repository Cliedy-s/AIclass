using System;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserMain1 : Form
    {
        public UserMain1()
        {
            InitializeComponent();
        }



        private void UserMain1_Load(object sender, EventArgs e)
        {
            UserLogin frm = new UserLogin();
            frm.MdiParent = this;
            picWhite1.Visible = false;
            picblack1.Visible = true;
            frm.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        { // TODO - 로그인다하고 홈 누르면 재시작?
            AdminMain frm = new AdminMain();
            frm.Show();
           // Application.Restart();
        } // 홈 버튼

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }// 로그아웃 버튼

        private void Button2_Click(object sender, EventArgs e)
        {
            UserOrderDetails frm = new UserOrderDetails();
            frm.Show();
        }// 주문 내역 버튼
    }
}

