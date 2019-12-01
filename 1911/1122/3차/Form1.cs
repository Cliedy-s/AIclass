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
using WindowsFormsApp22.util;
using WindowsFormsApp22.Service;

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
            CustomerService service = new CustomerService();
            List<CustomerVO> list = service.GetCustomerList();

            dataGridView1.DataSource = list;

            List<ComboItemVO> codeList = (from customer in list
             select new ComboItemVO { Code = customer.CustomerID, Text = customer.CompanyName }).ToList();

            util.CommonUtil.ComboBinding(comboBox1, codeList);

            //콤보박스 컨트롤 데이터바인딩
            InitComboBinding();
        }

        private void InitComboBinding()
        {
            CustomerService service = new CustomerService();
            List<ComboItemVO> list = service.GetCategoryRegionCodeList();

            List<ComboItemVO> regionList = (from item in list
                                          where item.Category == "Region"
                                            select item).ToList();
            CommonUtil.ComboBinding(comboBox2, regionList);

            List<ComboItemVO> categotyList = (from item in list
                                         where item.Category == "Category"
                                              select item).ToList();
            CommonUtil.ComboBinding(comboBox3, categotyList);
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
            ProductService service = new ProductService();
            dataGridView1.DataSource = service.GetProductInfoList();
        }
    }
}
