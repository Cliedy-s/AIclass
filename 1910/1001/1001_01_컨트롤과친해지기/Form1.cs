using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1001_01_컨트롤과친해지기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //if(!(Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            if(str.Length < 8)
            {
                MessageBox.Show("8글자 이상의 문장을 입력하세요");
                return;
            }
            textBox2.Text =str.Substring(0, 3);
            textBox3.Text =str.Substring(str.Length -3);
            textBox5.Text =str.Length.ToString();
            textBox4.Text = str.Substring(5, 3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Replace(" ", "");
            if (str.Length < 8)
            {
                MessageBox.Show("8글자 이상의 문장을 입력하세요");
                return;
            }
            textBox9.Text = str.Substring(0, 3);
            textBox8.Text = str.Substring(str.Length - 3, 3);
            textBox7.Text = str.Length.ToString();
            textBox6.Text = str.Substring(5, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cnt = 15;
            DateTime now = DateTime.Now;
            textBox11.Text = string.Format("{0}{1}", now.ToString("yyyyMMdd"), cnt.ToString().PadLeft(5, '0'));
        }

        private void TextBox10_Leave(object sender, EventArgs e)
        {
        }

        private void TextBox10_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int x = int.Parse(textBox10.Text);
                errorProvider1.SetError(textBox10, "");
            }
            catch(Exception err)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox10, "숫자만 입력해주세요");
            }
        }
    }
}
