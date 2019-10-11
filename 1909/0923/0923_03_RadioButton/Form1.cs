using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_03_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var control in grpContry.Controls)
            {
                if(control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked) sb.Append(radio.Text+", ");
                }
            }

            foreach (var control in panGender.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked) sb.Append(radio.Text + ", ");
                }
            }
            
            MessageBox.Show(sb.ToString().TrimEnd(',', ' ')+"(을)를 누르셨습니다." );
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton)
            {
                panArm.Visible = (sender as RadioButton).Checked;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // rdoMale.Checked = false; // checkedchange 일어남
        }
    }
}
