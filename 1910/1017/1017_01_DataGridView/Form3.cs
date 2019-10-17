using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1017_01_DataGridView
{
    public partial class Form3 : Form
    {
        DataSet dataSet;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            dataSet = new DataSet();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataSet.ReadXml("Data.xml");

            dataGridView1.DataSource = dataSet.Tables[0];
        }

    }
}
