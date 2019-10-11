using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_06_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(cmbDishs.Text !="" ) cmbDishs.Items.Add(cmbDishs.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(cmbDishs.SelectedIndex > 0) cmbDishs.Items.RemoveAt(cmbDishs.SelectedIndex);
        }

        private void CmbDishs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Text = "오늘 먹을 음식은 " + cmbDishs.SelectedItem.ToString() +"입니다." ;
        }
    }
}
