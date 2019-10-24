using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUserControls
{
    public partial class AddressUserControl : UserControl
    {
        string zip;
        string addr1;
        string addr2;
        AddressSearchForm frm;

        [Description("Zipcode")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Zip { get => zip; }
        [Description("Addr1")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Addr1 { get => addr1; }
        [Description("Addr2")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Addr2 { get => addr2; }
        public AddressUserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frm = new AddressSearchForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                zip = frm.Zip;
                addr1 = frm.Addr1;
                addr2 = frm.Addr2;
            }
        }
    }
}
