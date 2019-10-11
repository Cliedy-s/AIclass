using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_03_TimerProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            progressBar1.Value = progressBar1.Maximum;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            if (progressBar1.Value > 0) progressBar1.Value --;
            else timer1.Stop();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(timer1.Interval - 10 > 0)
                    timer1.Interval -= 10;
                //timer1.Stop();
                textBox1.Text = "";
                progressBar1.Value = progressBar1.Maximum;
            }
        }
    }
}
