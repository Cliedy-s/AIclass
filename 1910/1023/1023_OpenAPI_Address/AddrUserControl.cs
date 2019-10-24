using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1023_OpenAPI_Address
{
    public partial class AddrUserControl : UserControl
    {
        string zip;
        string addr1;
        string addr2;

        [Description("Zipcode")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Zip { get => textBox1.Text; }
        [Description("Addr1")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Addr1 { get => textBox2.Text; }
        [Description("Addr2")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Addr2 { get => textBox3.Text; }

        public AddrUserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddrSearchForm frm = new AddrSearchForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = frm.Zip;
                textBox2.Text = frm.Addr1;
                textBox3.Text = frm.Addr2;
            }
        }
    }
}
