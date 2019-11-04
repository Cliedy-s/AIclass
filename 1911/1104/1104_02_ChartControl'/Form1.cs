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
using System.Windows.Forms.DataVisualization.Charting;

namespace _1104_02_ChartControl_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connstr;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series1"));
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.Add(100); // x 입력안할시 자동 증가
            chart1.Series["Series1"].Points.Add(200);
            chart1.Series["Series1"].Points.Add(300);
            chart1.Series["Series1"].Points.Add(400);
            chart1.Series["Series1"].Points.Add(100); 
            chart1.Series["Series1"].Points.Add(200);
            chart1.Series["Series1"].Points.Add(300);
            chart1.Series["Series1"].Points.Add(400);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series1"));
            chart1.Series.Add(new Series("Series2"));

            chart1.Series["Series2"].ChartType = SeriesChartType.Line;
            chart1.Series["Series2"].BorderWidth = 5;

            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.Add(100); // x 입력안할시 자동 증가
            chart1.Series["Series1"].Points.Add(200);
            chart1.Series["Series1"].Points.Add(300);
            chart1.Series["Series1"].Points.Add(400);

            chart1.Series["Series2"].Points.Clear();
            chart1.Series["Series2"].Points.Add(100);
            chart1.Series["Series2"].Points.Add(200);
            chart1.Series["Series2"].Points.Add(300);
            chart1.Series["Series2"].Points.Add(400);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series1"));
            chart1.Series.Add(new Series("Series2"));

            connstr = ConfigurationManager.ConnectionStrings["employee"].ConnectionString;
            using(MySqlConnection conn = new MySqlConnection(connstr))
            {
                string sql = "select e.emp_no, concat(e.first_name, ' ', e.last_name) emp_name, year(s.from_date) as year, avg(s.salary) as salary from salaries s inner join (select emp_no, first_name, last_name from employees where emp_no in(10001, 10004)) e on e.emp_no = s.emp_no group by e.emp_no, concat(e.first_name, ' ', e.last_name), year(from_date) order by 1, 2; ";

                DataSet set = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(set);
                conn.Close();

                DataView dv01 = new DataView(set.Tables[0]);
                dv01.RowFilter = "emp_no = '10001'";

                DataView dv02 = new DataView(set.Tables[0]);
                dv02.RowFilter = "emp_no = '10004'";

                chart1.Series[0].Points.DataBind(dv01, "year", "salary", "Tooltip=salary"); // tolltip => alter text => 보여주고자 하는 칼럼주기
                chart1.Series[1].Points.DataBind(dv02, "year", "salary", "Tooltip=salary");
            }
        }
    }
}
