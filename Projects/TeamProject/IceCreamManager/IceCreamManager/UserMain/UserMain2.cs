﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class UserMain2 : Form
    {
        public UserMain2()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            UserMain3 frm = new UserMain3();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void UserMain2_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = "주니어";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = "레귤러";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label2.Text = "킹";
        }
    }
}
