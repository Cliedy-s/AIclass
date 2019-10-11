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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = "";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in panel1.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = item as CheckBox;
                    if(checkBox.Checked)
                    {
                        str.Append(checkBox.Text+ ", ");
                        //
                        /*
                        str.Append(checkBox.Text);
                        str.Append(", ");
                        */
                    }
                }
            }
            label3.Text = str.ToString().Trim(',', ' ');
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string[] strs = label3.Text.Replace(", ", " ").Split(' ');
            string str = label3.Text;

            foreach (var item in panel2.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = item as CheckBox;
                    checkBox.Checked = false;
                }
            }

            for (int i = 0; i < strs.Length; i++)
            {
                foreach (var item in panel2.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox checkBox = item as CheckBox;
                        if (strs[i] == checkBox.Text)
                        {
                            checkBox.Checked = true;
                            break;
                        }
                    }
                }
            }

            foreach (var item in panel2.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = item as CheckBox;
                    if (strs.Contains(checkBox.Text)) checkBox.Checked = true;
                }
            }

            //foreach (var item in panel2.Controls)
            //{
            //    if (item is CheckBox)
            //    {
            //        CheckBox checkBox = item as CheckBox;
            //        if (str.Contains(checkBox.Text)) checkBox.Checked = true;
            //    }
            //}
        }
    }
}
