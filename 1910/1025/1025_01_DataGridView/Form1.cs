using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1025_01_DinamicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DinamicControlCreate.DControls dc = new DinamicControlCreate.DControls();
            int im = int.Parse(textBox1.Text);
            int jm = int.Parse(textBox2.Text);

            int idx = 0;
            for (int i = 0; i < im ; i++)
            {
                for (int j = 0; j < jm; j++)
                {
                    panel1.Controls.Add(dc.CreateButton("btn" + idx.ToString(), new Size(20, 20), new Point(j * 20, i * 50)));
                    idx++;
                }
            }

            foreach (var item in panel1.Controls)
            {
                if(item is Button)
                {
                    Button button = item as Button;
                    button.BackColor = Color.Red;
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
        }
    }
}
