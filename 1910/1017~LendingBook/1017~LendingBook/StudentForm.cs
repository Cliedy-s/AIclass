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
            StudentSearchForm frm = new StudentSearchForm();
            if (DialogResult.OK == frm.ShowDialog())
            {
                // 입력한 학생정보 불러오기
                DataView dv = ((DataTable)studentGrid.DataSource).DefaultView;
                dv.Sort = "studentID";
                //int rowidx = dv.Find(frm.stdName);
                int rowidx = dv.Find(frm.StudentID);
                if (rowidx == -1) { 
                    MessageBox.Show("존재하지 않는 학번입니다."); 
                }
                else
                {
                    studentGrid.ClearSelection();
                    studentGrid.Rows[rowidx].Selected = true; // 못 찾으면 -1
                }
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StudentInUpForm frm = new StudentInUpForm();

            if (DialogResult.OK == frm.ShowDialog())
            {
                // 입력한 학생정보 불러오기
                Student student = frm.StudentInfo;
                StudentDB.StudentDB db = new StudentDB.StudentDB();
                db.Insert(student);
                db.Dispose();
            }
            LoadData();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadData();
            studentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentGrid.MultiSelect = false; 
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
            Student std = new Student();
            std.ID = Convert.ToInt32(studentGrid["studentid", studentGrid.CurrentRow.Index].Value);
            std.Name = studentGrid["studentname", studentGrid.CurrentRow.Index].Value.ToString();
            std.Dept = studentGrid["department", studentGrid.CurrentRow.Index].Value.ToString();
            frm.StudentInfo = std;
            if (DialogResult.OK == frm.ShowDialog())
            {
                // 입력한 학생정보 불러오기
                Student student = frm.StudentInfo;
                StudentDB.StudentDB db = new StudentDB.StudentDB();
                db.Update(student);
                db.Dispose();
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("정말로 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int studentID = Convert.ToInt32(studentGrid["studentid", studentGrid.CurrentRow.Index].Value.ToString());
                    StudentDB.StudentDB db = new StudentDB.StudentDB();
                    db.Delete(studentID);
                    db.Dispose();
                    LoadData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
            //Environment.Exit();
        }
    }
}
