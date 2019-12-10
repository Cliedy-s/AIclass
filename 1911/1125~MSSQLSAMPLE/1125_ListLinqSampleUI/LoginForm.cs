using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1125_ListLinqSampleUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CommonService service = new CommonService();
            string result = service.LoginCheck(txtFirstName.Text, txtLastName.Text);

            MessageBox.Show(result);
        }
    }
}
