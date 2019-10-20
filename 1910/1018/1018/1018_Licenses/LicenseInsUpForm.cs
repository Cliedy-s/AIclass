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
    public partial class LicenseInsUpForm : Form
    {
        public enum EditMode { Insert, Update }
        EditMode edtMode = EditMode.Insert;

        public int LicenseID
        {
            get { return Convert.ToInt32(txtLicenseID.Text); }
            set { txtLicenseID.Text = value.ToString(); }
        }
        public string LicenseName
        {
            get { return txtLicenseName.Text; }
            set { txtLicenseName.Text = value.ToString(); }
        }
        public int LicenseCost
        {
            get { return Convert.ToInt32(txtLicenseCost.Text); }
            set { txtLicenseCost.Text = value.ToString(); }
        }

        public LicenseInsUpForm(EditMode editMode)
        {
            InitializeComponent();
            this.edtMode = editMode;
        }

        private void LicenseInsUpForm_Load(object sender, EventArgs e)
        {
            if (edtMode == EditMode.Insert) { }
            else if (edtMode == EditMode.Update)
                txtLicenseID.Enabled = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TxtLicenseCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.DialogResult= DialogResult.OK;
        }
    }
}
