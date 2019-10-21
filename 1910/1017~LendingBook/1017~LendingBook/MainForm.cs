﻿using System;
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
    }
}