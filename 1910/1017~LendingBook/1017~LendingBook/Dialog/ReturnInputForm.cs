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
    public partial class ReturnInputForm : Form
    {
        public ReturnInputForm()
        {
            InitializeComponent();
        }

        public int BookID { get { return Convert.ToInt32(txtBookID.Text); }  }

        private void ReturnInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
