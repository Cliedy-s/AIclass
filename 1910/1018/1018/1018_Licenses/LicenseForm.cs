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
using License = DBClasses.License;

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
            LicenseInsUpForm frm = new LicenseInsUpForm(LicenseInsUpForm.EditMode.Insert);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LicenseDB ldb = new LicenseDB();
                ldb.Insert(new License(frm.LicenseID, frm.LicenseName, frm.LicenseCost));
                ldb.Dispose();
            }
            LoadData();
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvLicenseList.ReadOnly = true;
            dgvLicenseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadData()
        {
            DataSet dataset = new DataSet();

            LicenseDB ldb = new LicenseDB();
            dataset = ldb.GetAll();
            ldb.Dispose();

            dgvLicenseList.DataSource = dataset;
            dgvLicenseList.DataMember = "Licenses";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LicenseInsUpForm frm = new LicenseInsUpForm(LicenseInsUpForm.EditMode.Update);
            frm.LicenseID = Convert.ToInt32(dgvLicenseList["LicenseID", dgvLicenseList.CurrentRow.Index].Value);
            frm.LicenseName = dgvLicenseList["LicenseName", dgvLicenseList.CurrentRow.Index].Value.ToString();
            frm.LicenseCost = Convert.ToInt32(dgvLicenseList["LicenseCost", dgvLicenseList.CurrentRow.Index].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LicenseDB ldb = new LicenseDB();
                ldb.Update(new License(frm.LicenseID, frm.LicenseName, frm.LicenseCost));
                ldb.Dispose();
            }
            LoadData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하겠습니까?", "삭제", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                LicenseDB ldb = new LicenseDB();
                ldb.Delete(Convert.ToInt32(dgvLicenseList["LicenseID", dgvLicenseList.CurrentRow.Index].Value));
                ldb.Dispose();
            }
            LoadData();
        }
    }
}
