﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace IceCreamManager
{
    public partial class UserMain1 : Form
    {
        public UserMain1()
        {
            InitializeComponent();
        }

       

        private void UserMain1_Load(object sender, EventArgs e)
        {
            UserLogin frm = new UserLogin();
            frm.MdiParent = this;
            picBoxStep1.Visible = false;
            picBoxStep5.Visible = true;
            frm.Show();

        }
    }
}
