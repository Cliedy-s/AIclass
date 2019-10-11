using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0924_04_ClassGrammer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string TxtResult
        {
            get { return txtResult.Text; }
            set { txtResult.Text = value; }
        }
        public string LblSended
        {
            get { return lblSended.Text; }
            set { lblSended.Text = value; }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
