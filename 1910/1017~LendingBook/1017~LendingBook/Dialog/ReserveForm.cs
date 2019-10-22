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
    public partial class ReserveForm : Form
    {
        public ReserveForm()
        {
            InitializeComponent();
        }

        public int StudentID { get { return Convert.ToInt32(txtStudentID.Text); } }
        public int BookID { get { return Convert.ToInt32(txtBookID.Text); } }

        private void ReserveForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text.Length > 0 && txtStudentID.Text.Length > 0)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("다시 입력해 주세요");
        }
    }
}
