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
    public partial class StudentSearchForm : Form
    {
        public StudentSearchForm()
        {
            InitializeComponent();
        }

        public int StudentID { get { return Convert.ToInt32(txtStudentID.Text); } } // 읽기 전용 프로퍼티
        //public string stdName { get { return txtStudentID.Text; } } // 읽기 전용 프로퍼티

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)//(e.KeyChar == 13)
            {
                //입력x
                if (string.IsNullOrEmpty(txtStudentID.Text.Trim()))
                {
                    btnCancel.PerformClick();
                }
                else // 입력 o
                {
                    btnOK.PerformClick();
                }
                

            }
        }
    }
}
