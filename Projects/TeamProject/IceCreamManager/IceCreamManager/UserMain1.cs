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
    public partial class UserMain1 : Form
    {
        public UserMain1()
        {
            InitializeComponent();
        }

        private void UserMain1_Load(object sender, EventArgs e)
        {
            UserMain2 frm = new UserMain2();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}