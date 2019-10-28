using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1028_03_DataBinding
{
    public partial class Form2 : Form
    {
        MySqlDataAdapter da;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["memberInfo"].ConnectionString;
            string sql = "SELECT Name, Birth, Email, Family FROM MemberInfo; ";

            da = new MySqlDataAdapter(sql, sqlconn);
            dt = new DataTable();

            var commBuilder = new MySqlCommandBuilder(da);

            da.Fill(dt);

            this.bindingSource1.DataSource = dt;

            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            //안전빵
            this.Validate();
            this.dataGridView1.EndEdit();
            // 업데이트
            da.Update(dt);


        }
    }
}
