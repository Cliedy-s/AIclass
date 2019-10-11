using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0924_04_TreeView
{
    public partial class Form2 : Form
    {
        #region property
        public string ZipCode
        {
            get { return frm2txtZip.Text; }
            set { frm2txtZip.Text = value; }
        }
        public string Addr01
        {
            get { return frm2txtAddr01.Text; }
            set { frm2txtAddr01.Text = value; }
        }
        public string Addr02
        {
            get { return frm2txtAddr02.Text; }
            set { frm2txtAddr02.Text = value; }
        }
        #endregion
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string zipcode, string addr1, string addr2)
        {
            InitializeComponent(); // txtzip에 속성x

            this.ZipCode = zipcode;
            this.Addr01 = addr1;
            this.Addr02 = addr2;
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
