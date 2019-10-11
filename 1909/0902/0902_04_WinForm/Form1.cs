using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0902_04_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 한번만 뜨게 하기(1)
            Form2 frm2 = Form2.CreateForm();
            frm2.Show();
            frm2.Select(); // Focus
        }

        Form3 frm3 = null;
        private void Button2_Click(object sender, EventArgs e)
        {
            // 한번만 뜨게 하기(2)
            if(frm3 == null)
                frm3 = new Form3();
            frm3.count++;
            frm3.Show();

            // frm3.label1.Text = frm3.count.ToString(); // 실시간 + Modifier public => 안배운거에여
        }
    }
}
