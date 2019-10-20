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
            dgvLicenseList.ReadOnly = true;
            dgvLicenseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistryList.ReadOnly = true;
            dgvRegistryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadData();
        }
        private void LoadData()
        {
            DataSet data = new DataSet();

            //Load
            LicenseDB ldb = new LicenseDB();
            foreach (DataTable item in ldb.GetAll().Tables)
            {
                data.Tables.Add(item.Copy());
            }
            ldb.Dispose();

            LicenseRegistryDB lrdb = new LicenseRegistryDB();
            foreach (DataTable item in lrdb.GetAll().Tables)
            {
                data.Tables.Add(item.Copy());
            }
            lrdb.Dispose();
            //
            
            //setRelation
            DataRelation relation = new DataRelation("fk_license_licenseregistry", data.Tables["Licenses"].Columns["LicenseID"], data.Tables["licenseregistry"].Columns["LicesneID"]);
            data.Relations.Add(relation);
            //

            dgvLicenseList.DataSource = data;
            dgvLicenseList.DataMember = "licenses";
            dgvRegistryList.DataSource = data;
            dgvRegistryList.DataMember = "licenses.fk_license_licenseregistry";
        }
    }
}
