using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_02_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            //result.Text += (chkDog.Checked ==true) ? "개" : "";
            //result.Text += (chkCat.Checked == true) ? "고양이" : "";
            //result.Text += (chkSnake.Checked == true) ? "뱀" : "";
            //result.Text += (chkParrot.Checked == true) ? "앵무새" : "";
            //result.Text += (chkMonkey.Checked == true) ? "원숭이" : "";

            //if (chkDog.Checked)
            //    sb.Append(chkDog.Text)
            //if (chkCat.Checked)
            //    sb.Append(chkCat.Text);
            //if (chkSnake.Checked)
            //    sb.Append(chkSnake.Text);
            //if (chkParrot.Checked)
            //    sb.Append(chkParrot.Text);
            //if (chkMonkey.Checked)
            //    sb.Append(chkMonkey.Text);

            //CheckBox[] cBox = { chkDog, chkCat, chkSnake, chkParrot, chkMonkey };
            //foreach (var cbox in cBox)
            //{
            //    if (cbox.Checked)
            //        sb.Append(cbox.Text + " ,");
            //}

            //foreach (var control in this.Controls)
            //{
            //    if(control is CheckBox)
            //    {
            //        CheckBox checkBox = control as CheckBox;
            //        sb.Append(checkBox.Text + " ,");
            //    }
            //}

            //foreach (var control in grpAnimals.Controls)
            //{
            //    if (control is CheckBox)
            //    {
            //        CheckBox checkBox = control as CheckBox;
            //        if(checkbox.Checked) sb.Append(checkBox.Text + " ,");
            //    }
            //}

            Control.ControlCollection controls = panAnimals.Controls;
            foreach (var check in controls)
            {
                CheckBox checkbox = check as CheckBox;
                if (checkbox != null)
                {
                    if (checkbox.Checked) sb.Append(checkbox.Text + " ,");
                }
            }


            result.Text = sb.ToString().TrimEnd(',');
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if (panAnimals.Visible) panAnimals.Visible = false;
            //else panAnimals.Visible = true;

            // panAnimals.Visible = (panAnimals.Visible) ? false : true;

            panAnimals.Visible = !panAnimals.Visible;
        }

        private void ChkCat_CheckedChanged(object sender, EventArgs e)
        {
            chkCat02.Checked = chkCat.Checked;
        }
    }
}
