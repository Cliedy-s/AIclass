using DBClasses;
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
    public partial class LicenseRegistryForm : Form
    {
        public LicenseRegistryForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            LicenseRegistryInsForm frm = new LicenseRegistryInsForm();
            frm.Show();
        }

        private void LicenseRegistryForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            //DataSet dataset = new DataSet();

            //LicenseRegistryDB cdb = new LicenseRegistryDB();
            //dataset = cdb.GetAll();
            //cdb.Dispose();

            //dgvCustomerList.DataSource = dataset;
            //dgvCustomerList.DataMember = "Customers";
        }
    }
}
