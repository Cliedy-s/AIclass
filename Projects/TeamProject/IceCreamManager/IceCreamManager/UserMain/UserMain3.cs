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
    public partial class UserMain3 : Form
    {
        public UserMain3()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {        
            Application.Restart();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            UserMain2 frm = new UserMain2();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();
        }

        private void UserMain3_Load(object sender, EventArgs e)
        {

        }

       

       

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            UserMain4 frm = new UserMain4();
            frm.MdiParent = (UserMain1)this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = pictureBox2.BackgroundImage;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = pictureBox5.BackgroundImage;
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = pictureBox6.BackgroundImage;
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = pictureBox7.BackgroundImage;
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = pictureBox8.BackgroundImage;
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = pictureBox9.BackgroundImage;
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = pictureBox10.BackgroundImage;
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = pictureBox11.BackgroundImage;
        }
    }
}
