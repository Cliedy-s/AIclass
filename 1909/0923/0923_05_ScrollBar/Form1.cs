using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_05_ScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Scr_Scroll(object sender, ScrollEventArgs e)
        {
            txtR.Text = scrR.Value.ToString();
            txtG.Text = scrG.Value.ToString();
            txtB.Text = scrB.Value.ToString();
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            if (txtR.Text != "" && txtG.Text != "" && txtB.Text != "")
            {
                scrR.Value = int.Parse(txtR.Text);
                scrG.Value = int.Parse(txtG.Text);
                scrB.Value = int.Parse(txtB.Text);

                trbR.Value = scrR.Value;
                trbG.Value = scrG.Value;
                trbB.Value = scrB.Value;

                panColorShow.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panColorShow.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
        }

        private void Trb_Scroll(object sender, EventArgs e)
        {
            txtR.Text = trbR.Value.ToString();
            txtG.Text = trbG.Value.ToString();
            txtB.Text = trbB.Value.ToString();
        }
    }
}
