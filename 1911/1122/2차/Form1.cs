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
        string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

                //콤보박스 컨트롤 데이터바인딩
                InitComboBinding();
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

        private void InitComboBinding()
        {
            string sql = "select CAST(RegionID as VARCHAR) Code, RegionDescription [Text], 'Region' Category from Region union select CAST(CategoryID as VARCHAR) Code, CategoryName[Text], 'Category' Category from Categories";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<ComboItemVO> list = Helper.DataReaderMapToList<ComboItemVO>(reader);

            List<ComboItemVO> regionList = (from item in list
                                            where item.Category == "Region"
                                            select item).ToList();
            ComboBinding(comboBox2, regionList);

            List<ComboItemVO> categotyList = (from item in list
                                              where item.Category == "Category"
                                              select item).ToList();
            ComboBinding(comboBox3, categotyList);
        }

        private void ComboBinding(ComboBox combo, List<ComboItemVO> list)
        {
            list.Insert(0, new ComboItemVO());
            combo.DataSource = list;
            combo.DisplayMember = "Text";
            combo.ValueMember = "Code";
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

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select ProductID, ProductName, p.SupplierID, ");
            sb.Append("       CompanyName, p.CategoryID, CategoryName, ");
            sb.Append("       QuantityPerUnit, UnitPrice ");
            sb.Append("  from Products p inner join Suppliers s on p.SupplierID = s.SupplierID ");
            sb.Append("                  inner join Categories c on p.CategoryID = c.CategoryID");

            SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), connStr);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<ProductInfoVO> list = Helper.ConvertDataTableToList<ProductInfoVO>(dt);

            dataGridView1.DataSource = list;
        }
    }
}
