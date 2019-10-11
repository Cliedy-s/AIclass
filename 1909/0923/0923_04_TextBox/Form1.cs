using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_04_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            //if (textBox4.Text.Length > 5)
            //{
            //    textBox5.Focus();
            //}
            //if (textBox4.Text.Length > 6)
            //    textBox4.Text = textBox4.Text.Substring(0, 6);

        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (this.textBox4.Text.Length >= 5) this.textBox5.Focus();
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4 || textBox3.Text.Length > 8)
            {
                MessageBox.Show("비밀번호는 4~8글자 사이어야합니다.");
                textBox3.Focus();
                //textBox3.SelectAll();
                //textBox3.Select(0, 3);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(dtpDate.Text);
            //sb.Append(mtbDate.Text);
            sb.AppendLine(mtbPostNumber.Text);
            sb.AppendLine(mtbAddress.Text);
            sb.AppendLine(mtbPhone.Text);
            sb.AppendLine(mtbIDNumber.Text);
            sb.AppendLine(txtEmail.Text);
            MessageBox.Show(sb.ToString());
        }
    }
}
