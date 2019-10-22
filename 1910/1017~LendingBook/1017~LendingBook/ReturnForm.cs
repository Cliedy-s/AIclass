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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataSet dataset = new DataSet();
            LendingDB lendingdb = new LendingDB();
            dataset = lendingdb.GetAll();
            foreach (DataTable item in lendingdb.GetLendingItem().Tables)
            {
                dataset.Tables.Add(item.Copy());
            }
            lendingdb.Dispose();

            DataRelation relation = new DataRelation("fk_returndate", dataset.Tables["Book"].Columns["bookid"], dataset.Tables["LendingItem"].Columns["bookid"], false);
            dataset.Relations.Add(relation);

            DataView view01 = new DataView(dataset.Tables["Book"]);
            view01.RowFilter = "lendingstate = 1";

            //DataView view02 = new DataView(dataset.Tables["Book"]);
            //view02.RowFilter = "lendingstate = 0";

            dgvLendable.DataSource = view01;
            dgvUnlendable.DataSource = dataset;
            dgvUnlendable.DataMember = "Book.fk_returndate";
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ReturnInputForm frm = new ReturnInputForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LendingDB lendingdb = new LendingDB();
                lendingdb.ReturnBook(frm.BookID);
            }
            LoadData();
        }
    }
}
