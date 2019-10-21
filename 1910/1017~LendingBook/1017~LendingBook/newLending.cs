using BookDBClass;
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
    public partial class newLending : Form
    {
        public int StudentID { get {
                return Convert.ToInt32(txtStudentID.Text);
            } }
        public int[] AddedBooks { get {
                int[] ints = new int[lstLendBooks.Items.Count];
                for (int i = 0; i < lstLendBooks.Items.Count; i++)
                {
                    ints[i] = Convert.ToInt32(lstLendBooks.Items[i].ToString().Substring(0,6));
                }
                return ints;
            } }

        public newLending()
        {
            InitializeComponent();
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
            Book book = new Book();
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
                    if (bookDB.IsBooked(bookID, stdID))
                        throw new Exception("이미 예약된 책 입니다.");
                }
                // 이미 추가된 책인지 체크
                else if (IsAlreadyAdded(bookID))
                {
                    throw new Exception("이미 선택한 책 입니다.");
                }
                // 빌리자!
                else
                {
                    book = bookDB.GetbyBookID(bookID);
                    lstLendBooks.Items.Add(string.Format("{0,6} - {1,6}, {2,6}", book.bookid, book.bookname, book.author));
                    txtBookID.Text = "";
                    txtStudentID.Enabled = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        /// <summary>
        /// 리스트박스에 이미 있는지
        /// </summary>
        /// <param name="bookID">책 ID</param>
        /// <returns>true : 존재 , false : 존재x</returns>
        public bool IsAlreadyAdded(int bookID)
        {
            foreach (string item in lstLendBooks.Items)
            {
                if (bookID == Convert.ToInt32(item.Substring(0, 6))) // 형변환 줄이기
                // if (bookID.ToString() == item.Substring(0, 6).Trim())
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Trim().Length < 1)
            {
                MessageBox.Show("학번을 입력하세요.");
            }
            else if (lstLendBooks.Items.Count == 0)
            {
                MessageBox.Show("책을 선택하세요.");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
