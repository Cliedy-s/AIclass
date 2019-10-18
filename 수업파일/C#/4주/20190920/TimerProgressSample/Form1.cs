using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerProgressSample
{
    public partial class Form1 : Form
    {
        bool bStart = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            //timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

            if (progressBar1.Value > 0)
                this.progressBar1.Value--;
            else
                timer1.Stop();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            this.timer1.Start();
            progressBar1.Value = 100;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!bStart)
            {
                progressBar1.Value = 100;
                timer1.Interval = 100;
                timer1.Start();
                bStart = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                timer1.Stop();
                bStart = false;
            }
        }
    }
}
