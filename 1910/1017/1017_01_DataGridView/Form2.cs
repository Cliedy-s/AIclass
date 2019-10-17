using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1017_01_DataGridView
{
    public partial class Form2 : Form
    {
        string strConn = string.Empty;
        DataSet dataSet = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //set dataGridView1

            //
            // getTables

            // conn
            strConn = ConfigurationManager.ConnectionStrings["employeesDatabaseConnectionString"].ConnectionString;
            //

            dataSet = new DataSet();
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                string sql = "select emp_no, dept_no, from_date, to_date from dept_manager where to_date = '9999-01-01'; ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                conn.Open();
                adapter.Fill(dataSet, "dept_manager");
                sql = "select emp_no, dept_no, from_date, to_date from dept_emp where  to_date = '9999-01-01'; ";
                adapter.SelectCommand.CommandText = sql;
                adapter.Fill(dataSet, "dept_emp");

            }
            // 테이블 간 관계 추가
            DataRelation dataRelation = new DataRelation("FK_deptManager_deptEmp_deptNo"
                                                                          , dataSet.Tables["dept_manager"].Columns["dept_no"]
                                                                          , dataSet.Tables["dept_emp"].Columns["dept_no"]);
            dataSet.Relations.Add(dataRelation);
            // 소스 설정
            // 1.
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "dept_manager";

            // 2.
            //dataGridView2.DataSource = dataSet.Tables["dept_emp"];
            dataGridView2.DataSource = dataSet;
            dataGridView2.DataMember = "dept_manager.FK_deptManager_deptEmp_deptNo";
            //
        }

        private void btnWriteXML_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                dataSet.WriteXml(fileStream);
                MessageBox.Show("Xml File Export!");
            }
        }

        //public void AddNewColumnToDataGridView(string headerText, string name, string dataPropertyName,
        //                                                            DataGridView dataGridView, Type type, int colWidth = 100, bool visibility = true,
        //                                                            DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleCenter)
        //{
        //    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
        //    col.HeaderText = headerText;
        //    col.Name = name;
        //    col.DataPropertyName = dataPropertyName;
        //    col.Width = colWidth;
        //    col.Visible = visibility;
        //    col.ValueType = type;
        //    col.ReadOnly = true;
        //    col.DefaultCellStyle.Alignment = alignment;
        //    dataGridView.Columns.Add(col);
        //}
    }
}
