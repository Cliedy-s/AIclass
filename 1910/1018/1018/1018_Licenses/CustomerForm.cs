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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            CustomerInsUpForm frm = new CustomerInsUpForm(CustomerInsUpForm.EditMode.Insert);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                CustomerDB cdb = new CustomerDB();
                cdb.Insert(new Customer(frm.CustomerID, frm.CustomerName));
                cdb.Dispose();
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerInsUpForm frm = new CustomerInsUpForm(CustomerInsUpForm.EditMode.Update);
            frm.CustomerID = Convert.ToInt32(dgvCustomerList["CustomerID", dgvCustomerList.CurrentRow.Index].Value);
            frm.CustomerName = dgvCustomerList["CustomerName", dgvCustomerList.CurrentRow.Index].Value.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CustomerDB cdb = new CustomerDB();
                cdb.Update(new Customer(frm.CustomerID, frm.CustomerName));
                cdb.Dispose();
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하겠습니까?","삭제",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                CustomerDB cdb = new CustomerDB();
                cdb.Delete(Convert.ToInt32(dgvCustomerList["CustomerID", dgvCustomerList.CurrentRow.Index].Value));
                cdb.Dispose();
            }
            LoadData();
        }
        private void LoadData()
        {
            DataSet dataset = new DataSet();

            CustomerDB cdb = new CustomerDB();
            dataset = cdb.GetAll();
            cdb.Dispose();

            dgvCustomerList.DataSource = dataset;
            dgvCustomerList.DataMember = "Customers";
            dgvCustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
