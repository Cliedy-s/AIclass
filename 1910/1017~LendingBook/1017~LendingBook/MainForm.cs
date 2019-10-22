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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 학생관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm studentform = new StudentForm();
            studentform.Show();
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookform = new BookForm();
            bookform.Show();
        }

        private void 대여관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LendingForm lendingForm = new LendingForm();
            lendingForm.Show();
        }

        private void 반납괸라ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm returnform = new ReturnForm();
            returnform.Show();
        }

        private void 제품정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 보이기 전에 일어나는 이벤트
            LoginForm frm = new LoginForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                frm.Close();
            } else
            {
                Dispose();
            }
        }
    }
}
