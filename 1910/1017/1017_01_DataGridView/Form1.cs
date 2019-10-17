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

namespace _1017_01_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string goodieConnectionString = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AddNewColumnToDataGridView("회원ID","userID","userID",dataGridView1, typeof(string), 100, true, DataGridViewContentAlignment.MiddleLeft);
            AddNewColumnToDataGridView("비밀번호", "userPWD", "userPWD", dataGridView1, typeof(string), 150);

            goodieConnectionString = ConfigurationManager.ConnectionStrings["goodieDatabaseConnectionString"].ConnectionString;
            txtID.Focus();
            btnUpdate.Enabled = false;
            DataRetrieve();
        }

        public void AddNewColumnToDataGridView( string headerText, string name, string dataPropertyName,
                                                                    DataGridView dataGridView, Type type, int colWidth = 100, bool visibility = true,
                                                                    DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleCenter)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.Name = name;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = type;
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = alignment;
            dataGridView.Columns.Add(col);
        }

        private void DataRetrieve(bool isAll = true, string name = "")
        {
            txtID.Enabled = true;
            StringBuilder sql1 = new StringBuilder(string.Format(" select userID, userPWD, userName from members where 1=1 "));
            if (!isAll)
            {
                sql1.Append(" and userName = '" + name + "' ");
            }
            using (MySqlConnection connection = new MySqlConnection(goodieConnectionString))
            {
                MySqlCommand command = new MySqlCommand(sql1.ToString(), connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                dataGridView1.DataSource = data;
            }
        }
    }
}
