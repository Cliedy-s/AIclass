using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1018_Licenses
{
    public partial class CustomerInsUpForm : Form
    {
        public enum EditMode { Insert, Update }
        EditMode edtMode = EditMode.Insert;

        public int CustomerID { 
            get { return Convert.ToInt32(txtCustomerID.Text);  }
            set { txtCustomerID.Text = value.ToString() ; } 
        }
        public string CustomerName { 
            get { return txtCustomerName.Text; }
            set { txtCustomerName.Text = value.ToString(); }
        }
        public CustomerInsUpForm(EditMode editMode)
        {
            InitializeComponent();
            this.edtMode = editMode;
        }

        private void CustomerInsUpForm_Load(object sender, EventArgs e)
        {
            if (edtMode == EditMode.Insert) { }
            else if (edtMode == EditMode.Update)
                txtCustomerID.Enabled = false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TxtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.DialogResult = DialogResult.OK;
        }
    }
}
