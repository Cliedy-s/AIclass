using BookDBClass;
using StudentDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _1017_LendingBook.StudentInUpForm;

namespace _1017_LendingBook
{
    public partial class BookForm: Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            BookInUpForm frm = new BookInUpForm();

            if(DialogResult.OK == frm.ShowDialog())
            {
                // 입력한 학생정보 불러오기
                Book book = frm.BookInfo;
                BookDB db = new BookDB();
                MessageBox.Show(db.Insert(book));
                db.Dispose();
            }
            LoadData();
        }

        private void LoadData()
        {
            BookDB db = new BookDB();
            bookGrid.DataSource = db.GetAll().Tables["Student"];
            db.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookInUpForm frm = new BookInUpForm(BookInUpForm.EditMode.Update);
            // frm.StudentInfo = 
            if (DialogResult.OK == frm.ShowDialog())
            {
                // 입력한 학생정보 불러오기
                Book book = frm.BookInfo;
                BookDB db = new BookDB();
                MessageBox.Show(db.Insert(book));
                db.Dispose();
            }
            LoadData();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
