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

namespace _1017_LendingBook
{
    public partial class StudentInUpForm : Form
    {
        public enum EditMode { Input, Update };
        public Student StudentInfo {
            get => new Student(Convert.ToInt32(txtStudentID.Text), txtStudentName.Text, txtDepartment.Text);
            set {
                txtStudentID.Text = value.ID.ToString();
                txtDepartment.Text = value.Dept;
                txtStudentName.Text = value.Name;
            }
        }
        public StudentInUpForm()
        {
            InitializeComponent();
        }
        public StudentInUpForm(EditMode editMode = EditMode.Input) : this()
        {
            if(editMode == EditMode.Update)
            {
                this.Text = "학생 정보 수정";
                txtStudentID.Enabled = false;
                btnOK.Text = "수정";
            }
            else if (editMode == EditMode.Input)
            {
                this.Text = "학생 정보 입력";
                btnOK.Text = "추가";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        }
        private void StudentInUpForm_Load(object sender, EventArgs e)
        {

        }

    }
}
