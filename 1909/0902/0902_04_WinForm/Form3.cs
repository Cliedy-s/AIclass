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
    public partial class Form3 : Form
    {
        public int count = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            // 실시간 + 마우스 오버
            label1.Text = count.ToString();
        }
    }
}
