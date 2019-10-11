using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0902_04_WinForm
{
    public partial class Form2 : Form
    {
        int count = 0;
        static Form2 frm;

        public int Count { get => count; set => count = value; }

        private Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Count++;
            label1.Text = Count.ToString();
        }
        static public Form2 CreateForm()
        {
            if(frm ==null)
                frm = new Form2();
            return frm;
        }
    }
}
