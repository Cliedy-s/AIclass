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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StudentInUpForm frm = new StudentInUpForm();

            if(DialogResult.OK == frm.ShowDialog())
            {
                // 입력한 학생정보 불러오기
                Student student = frm.StudentInfo;
                StudentDB.StudentDB db = new StudentDB.StudentDB();
                MessageBox.Show(db.Insert(student));
                db.Dispose();
            }
            LoadData();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            StudentDB.StudentDB db = new StudentDB.StudentDB();
            studentGrid.DataSource = db.GetAll().Tables["Student"];
            db.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentInUpForm frm = new StudentInUpForm(EditMode.Update);
            // frm.StudentInfo = 
            if (DialogResult.OK == frm.ShowDialog())
            {
                // 입력한 학생정보 불러오기
                Student student = frm.StudentInfo;
                StudentDB.StudentDB db = new StudentDB.StudentDB();
                MessageBox.Show(db.Insert(student));
                db.Dispose();
            }
            LoadData();
        }
    }
}
