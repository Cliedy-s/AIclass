using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class AddressUserControl : UserControl
    {
        [Description("Zipcode")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Zip { get => textBox1.Text; set => textBox1.Text = value; }
        [Description("Addr1")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Addr1 { get => textBox2.Text; set => textBox2.Text = value; }
        [Description("Addr2")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Addr2 { get => textBox3.Text; set => textBox3.Text = value; }
        public AddressUserControl()
        {
            InitializeComponent();
        }

        AddressSearchForm frm;
        private void Button1_Click(object sender, EventArgs e)
        {
            frm = new AddressSearchForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = frm.Zip;
                textBox2.Text = frm.Addr1;
                textBox3.Text = frm.Addr2;
            }
        }
    }
}
