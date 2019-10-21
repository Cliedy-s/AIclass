using BookDBClass;
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
    public partial class newLending : Form
    {
        public newLending()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void newLending_Load(object sender, EventArgs e)
        {
            txtBookID.Enabled = false;
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentID.Text)) txtBookID.Enabled = true;
            else
                txtBookID.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookDB bookDB = new BookDB();
            txtStudentID.Enabled = false;
            try
            {
                int bookID = int.Parse(txtBookID.Text);
                int stdID = int.Parse(txtStudentID.Text);
                // 책 번호가 유효한지 체크
                if (!bookDB.IsValid(bookID))
                    throw new Exception("예약된 책인지, 존재하는 책인지 확인해주세요");
                // 대여 중인 책인지 체크
                else if (bookDB.IsLended(bookID))
                    throw new Exception("이미 대여중인 책 입니다.");
                // 예약된 책인지 체크
                else if (bookDB.IsBooked(bookID))
                {
                    // 예약자가 입력된 학생인지
                    if (!bookDB.IsBooked(bookID, stdID))
                        throw new Exception("이미 예약된 책 입니다.");
                }
                // 이미 추가된 책인지 체크
                // 좀있다가..ㅎ
                // 빌리자!
                else
                {
                    lstLendBooks.Items.Add(string.Format("{0,6} - {1,6}, {2,6}", bookID,  "",""));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }
    }
}
