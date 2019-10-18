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
        public LendingForm()
        {
            InitializeComponent();
        }

        private void LendingForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ds = new DataSet();
            LendingDB lendingDB = new LendingDB();
            ds = lendingDB.GetAll();
            lendingDB.Dispose();

            DataView dvLendable = new DataView(ds.Tables["Book"]);
            dvLendable.RowFilter = "lendingstate = 0";
            groupBox1.Text = "대여 가능 목록";
            dgvLendable.DataSource = dvLendable;

            DataView dvUnLendable = new DataView(ds.Tables["Book"]);
            dvUnLendable.RowFilter = "lendingstate = 1";
            groupBox2.Text = "대여 불가능 목록";
            dgvUnlendable.DataSource = dvUnLendable;
        }

        private void btnLendlist_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            newLending frm = new newLending();
            if(frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
