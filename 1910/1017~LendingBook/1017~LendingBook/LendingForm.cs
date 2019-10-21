using BookDBClass;
using LendingDBClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1017_LendingBook
{
    public partial class LendingForm : Form
    {
        DataSet ds;
        DataType datatype = DataType.Lending;
        public LendingForm()
        {
            InitializeComponent();
        }

        private void LendingForm_Load(object sender, EventArgs e)
        {
            LoadData();

            dgvLendable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLendable.ReadOnly = true;
            dgvUnlendable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnlendable.ReadOnly = true;
        }

        enum DataType { Reserve, Lending }
        private void LoadData()
        {
            ds = new DataSet();
            LendingDB lendingDB = new LendingDB();
            ds = lendingDB.GetAll();
            lendingDB.Dispose();

            DataView dvAble = new DataView(ds.Tables["Book"]);
            DataView dvUnable = new DataView(ds.Tables["Book"]);

            switch (datatype)
            {
                case DataType.Lending:
                    groupBox1.Text = "대여 가능 목록";
                    groupBox2.Text = "대여 불가능 목록";
                    dvAble.RowFilter = "lendingstate = 0";
                    dvUnable.RowFilter = "lendingstate = 1";
                    break;
                case DataType.Reserve:
                    groupBox1.Text = "예약 가능 목록";
                    groupBox2.Text = "예약 불가능 목록";
                    dvAble.RowFilter = "reservestuid = 0 and lendingstate = 0";
                    dvUnable.RowFilter = "reservestuid <> 0";
                    break;
            }
            dgvLendable.DataSource = dvAble;
            dgvUnlendable.DataSource = dvUnable;
        }

        private void btnLendlist_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "대여 가능 목록";
            groupBox2.Text = "대여 불가능 목록";
            datatype = DataType.Lending;
            LoadData();
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            newLending frm = new newLending();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LendingDB lendingDB = null;
                try
                {
                    lendingDB = new LendingDB();
                    lendingDB.LendBook(frm.StudentID, frm.AddedBooks);
                    LoadData();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    lendingDB.Dispose();
                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReserveList_Click(object sender, EventArgs e)
        {
            datatype = DataType.Reserve;
            LoadData();
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            ReserveForm frm = new ReserveForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LendingDB ledingDB = null;
                try
                {
                    ledingDB = new LendingDB();
                    ledingDB.Reserve(frm.StudentID, frm.BookID);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    ledingDB.Dispose();
                }
                LoadData();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
