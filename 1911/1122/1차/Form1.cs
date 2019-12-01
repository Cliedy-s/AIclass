using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            try
            {   
                string sql = "select CustomerID, CompanyName, ContactName, ContactTitle, Address, City from Customers";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CustomerVO> list = Helper.DataReaderMapToList<CustomerVO>(reader);
                dataGridView1.DataSource = list;

                List<ComboItemVO> codeList = (from customer in list
                               select new ComboItemVO 
                               { Code = customer.CustomerID, Text = customer.CompanyName }).ToList();

                codeList.Insert(0, new ComboItemVO());
                comboBox1.DataSource = codeList;
                comboBox1.DisplayMember = "Text";
                comboBox1.ValueMember = "Code";
                reader.Close();

                sql = "select CAST(RegionID as VARCHAR) Code, RegionDescription [Text] from Region";
                cmd.CommandText = sql;
                SqlDataReader regreader = cmd.ExecuteReader();
                List<ComboItemVO> regList = Helper.DataReaderMapToList<ComboItemVO>(regreader);
                regList.Insert(0, new ComboItemVO());
                comboBox2.DataSource = regList;
                comboBox2.DisplayMember = "Text";
                comboBox2.ValueMember = "Code";
                regreader.Close();

                sql = "select CAST(CategoryID as VARCHAR) Code, CategoryName Text from Categories";
                cmd.CommandText = sql;
                SqlDataReader catereader = cmd.ExecuteReader();
                List<ComboItemVO> cateList = Helper.DataReaderMapToList<ComboItemVO>(catereader);
                cateList.Insert(0, new ComboItemVO());
                comboBox3.DataSource = cateList;
                comboBox3.DisplayMember = "Text";
                comboBox3.ValueMember = "Code";
                catereader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                string selValue = comboBox1.SelectedValue.ToString();
                string selText = comboBox1.Text;

                MessageBox.Show($"선택한 정보:{selValue} - {selText}");
            }
        }
    }
}
