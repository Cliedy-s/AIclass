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
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            LicenseInsUpForm frm = new LicenseInsUpForm();
            frm.Show();
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            //DataSet dataset = new DataSet();

            //LicenseDB cdb = new LicenseDB();
            //dataset = cdb.GetAll();
            //cdb.Dispose();

            //dgvCustomerList.DataSource = dataset;
            //dgvCustomerList.DataMember = "Customers";
        }
    }
}
