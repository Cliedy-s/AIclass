﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0924_04_ClassGrammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.LblSended = txtSend.Text;
            if(DialogResult.OK == frm2.ShowDialog())
            {
                frm2.Dispose();
                lblResult.Text = frm2.TxtResult;
            }
        }
    }
}
