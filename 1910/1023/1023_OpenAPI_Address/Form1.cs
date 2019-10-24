using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace _1023_OpenAPI_Address
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            StringBuilder str = new StringBuilder();
            str.AppendLine("home : " + addrUserControl1.Zip);
            str.AppendLine("home : " + addrUserControl1.Addr1);
            str.AppendLine("home : " + addrUserControl1.Addr2);

            str.AppendLine("company : " + addrUserControl2.Zip);
            str.AppendLine("company : " + addrUserControl2.Addr1);
            str.AppendLine("company : " + addrUserControl2.Addr2);

            MessageBox.Show(str.ToString());
        }
    }
}
