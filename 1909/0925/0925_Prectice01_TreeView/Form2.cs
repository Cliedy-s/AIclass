using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0925_Prectice01_TreeView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string NameText
        {
            get { return textBox1.Text; }
        }
        public string TextText
        {
            get { return textBox2.Text; }
        }
        public string TegText
        {
            get { return textBox3.Text; }
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
