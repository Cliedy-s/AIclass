using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1017_LendingBook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // admin - 1234?

            //if(!(textBox1.Text== "admin" && textBox2.Text=="1234"))
            //{
            //    // 로그인 성공?
            //    // if (!)
            //    {
            //        // 실패
            //        return;
            //    }
            //}
            //

            this.DialogResult = DialogResult.OK;    
        }
    }
}
