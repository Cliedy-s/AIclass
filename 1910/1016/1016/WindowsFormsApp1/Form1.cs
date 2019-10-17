using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["LocalConnectionString"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                int result = 0;
                using (connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand("select count(*) from employees", connection);

                    // MessageBox.Show("연결성공!");
                    connection.Open(); // open에서 close까지 시간을 최대한 줄이는 게 좋음
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                MessageBox.Show(result.ToString());
            }
            catch (MySqlException)
            {
                MessageBox.Show("연결실패!");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            MySqlConnection connection = null;
            MySqlDataReader reader = null;
            BindingList<ComboData> list = new BindingList<ComboData>();
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "select dept_no, dept_name from departments;";
                    command.Connection = connection;

                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ComboData item = new ComboData();
                        //item.Code = reader.GetString(0);
                        //item.Text = reader.GetString(1);
                        item.Code = reader["dept_no"].ToString();
                        item.Text = reader["dept_name"].ToString();

                        list.Add(item);
                    }
                    reader.Close();
                    connection.Close();
                }
                
                cmbDepartments.DisplayMember = "Text"; 
                cmbDepartments.ValueMember = "Code";
                cmbDepartments.DataSource = list;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            */

            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Uid=root;Pwd=1234;Database=employees;");


            string sql = "select dept_no, dept_name from departments";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            BindingList<ComboData> list = new BindingList<ComboData>();
            while (reader.Read())
            {
                list.Add(new ComboData(reader["dept_no"].ToString(),
                                                        reader["dept_name"].ToString()));
            }
            reader.Close();
            conn.Close();
            cmbDepartments.DisplayMember = "Text";
            cmbDepartments.ValueMember = "Code";
            cmbDepartments.DataSource = list;
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            //MySqlConnection connection = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                /*
                StringBuilder strCommnad = new StringBuilder();
                strCommnad.Append("select concat(first_name, ' ', last_name) as emp_name, de.dept_no ");
                strCommnad.Append("from employees e "); 
                strCommnad.Append("     inner join ( select emp_no, dept_no from dept_emp where dept_no = '"+ cmbDepartments.SelectedValue.ToString() + "' and to_date = '9999-01-01' ) de on de.emp_no = e.emp_no ");
                */

            //StringBuilder strCommnad = new StringBuilder(string.Format("select concat(first_name, ' ', last_name) as emp_name, de.dept_no "+
            //                                                                "from employees e "+
            //                                                                "inner join ( select emp_no, dept_no from dept_emp where dept_no = '" + cmbDepartments.SelectedValue.ToString() + "' and to_date = '9999-01-01' ) de on de.emp_no = e.emp_no "));

            /*
            StringBuilder strCommnad = new StringBuilder();
            strCommnad.Append("select concat(first_name, ' ', last_name) as emp_name, de.dept_no ");
            strCommnad.Append("from employees e ");
            strCommnad.Append("     inner join ( select emp_no, dept_no from dept_emp where dept_no = '" + cmbDepartments.SelectedValue.ToString() + "'  and to_date = '9999-01-01' ) de on de.emp_no = e.emp_no ");

            MySqlCommand command = new MySqlCommand(strCommnad.ToString(), connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            BindingList<ComboData> list = new BindingList<ComboData>();
            while (reader.Read())
            {
                //Debug.WriteLine(reader["dept_no"].ToString()+ reader["emp_name"].ToString());
                list.Add(new ComboData(reader["dept_no"].ToString(), reader["emp_name"].ToString()));
            }


            DataTable data = new DataTable();
            data.Load(command.ExecuteReader());

            dataGridView1.DataSource = data;

            reader.Close();
        }

        */
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=1234;Database=employees"))
            {


                StringBuilder sb = new StringBuilder();

                sb.Append(" select e.emp_no, birth_date,concat(first_name, ' ', last_name) as emp_name, gender, hire_date ");
                sb.Append(" from employees e inner join dept_emp de on e.emp_no = de.emp_no ");
                sb.Append(" where dept_no = '" + cmbDepartments.SelectedValue.ToString() + "' and to_date = '9999-01-01' ");
                sb.Append(" order by emp_name ");


                MySqlCommand cmd = new MySqlCommand(sb.ToString(), conn);
                conn.Open();
                //MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //dt.Load(reader);
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // DataAdapter
            MySqlConnection connection = new MySqlConnection(connectionString);
            string commandstr = "select dept_no, dept_name from departments;";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandstr, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataAdapter.Fill(ds);
            connection.Close();

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "dept_name";
            comboBox1.ValueMember = "dept_no";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            using (connection = new MySqlConnection(connectionString))
            {
                StringBuilder strCommnad = new StringBuilder();
                strCommnad.Append("select concat(first_name, ' ', last_name) as emp_name, de.dept_no ");
                strCommnad.Append("from employees e ");
                strCommnad.Append("     inner join ( select emp_no, dept_no from dept_emp where dept_no = '" + comboBox1.SelectedValue.ToString() + "' and to_date = '9999-01-01' ) de on de.emp_no = e.emp_no ");

                MySqlDataAdapter adapter = new MySqlDataAdapter(strCommnad.ToString(), connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "MyEmployee");
                dataGridView2.DataSource = ds.Tables["MyEmployee"];
            }
        }


    }
    class ComboData
    {
        public string Code { get; set; }
        public string Text { get; set; }

        public ComboData(string code, string text)
        {
            Code = code;
            Text = text;
        }

        public ComboData() { }
    }
}
