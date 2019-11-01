using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeesService eService = new EmployeesService();
            BindingList<EmployeeDTO> ebindlist = new BindingList<EmployeeDTO>(eService.SelectAll());
            eService.Dispose();
            comboBox1.DataSource = ebindlist;
            comboBox1.DisplayMember = "IdAndName";
            comboBox1.ValueMember = "EmployeeID";
        }
    }
}
