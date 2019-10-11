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
    public partial class Form3 : Form
    {
        List<string> list;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            list = new List<string>();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.Append(" / ");
            sb.Append(textBox2.Text);
            listBox1.Items.Add(sb.ToString());
            list.Add(sb.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int value;
            if (radioButton1.Checked) value = 0;
            else if (radioButton2.Checked) value = 1;
            else return;

            //string[] strs;
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    strs = listBox1.Items[i].ToString().Replace(" ", "").Split('/');
            //    if (strs[value] == textBox3.Text) listBox1.SetSelected(i, true);
            //}

            listBox1.Items.Clear();
            string str;
            string[] strs = new string[2];
            foreach (var item in list)
            {
                str = item.ToString();
                strs = str.Replace(" ", "").Split('/');
                if (strs[value] == textBox3.Text) listBox1.Items.Add(str);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}
