using System;
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
    }
}
