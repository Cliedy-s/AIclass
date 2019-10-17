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

namespace _1017_LendingBook
{
    public partial class BookInUpForm : Form
    {
        public enum EditMode { Input, Update };
        public Book BookInfo { 
            get => new Book(txtBookID.Text, txtBookName.Text, txtAuthor.Text, txtPublisher.Text);
            set { }
        }
        public BookInUpForm ()
        {
            InitializeComponent();
        }
        public BookInUpForm (EditMode editMode = EditMode.Input) : this()
        {
            if(editMode == EditMode.Update)
            {
                this.Text = "책 정보 수정";
                txtBookID.Enabled = false;
                btnOK.Text = "수정";
            }
            else if (editMode == EditMode.Input)
            {
                this.Text = "책 정보 입력";
                btnOK.Text = "추가";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        }

    }
}
