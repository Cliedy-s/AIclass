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

namespace _1105_01_Static
{
    public partial class Form2 : Form
    {
        DateTime date;
        DataTable data;
        string connstr;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connstr);
            data = new DataTable();
            string sql = "select code, name, category, pcode from commoncode where Category in ('SCHOOL','JOB','M_TYPE'); ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            conn.Open();
            adapter.Fill(data);
            conn.Close();

            CommonCodeBinding("SCHOOL", comboBox1);
            CommonCodeBinding("JOB", comboBox2);
            CommonCodeBinding("M_TYPE", comboBox3);
        }

        private void CommonCodeBinding(string categoryFilter, ComboBox combobox, string pCode = "")
        {
            DataView dv = new DataView(data);
            if (string.IsNullOrEmpty(pCode))
                dv.RowFilter = "category = '" + categoryFilter + "' and pcode = ''";
            else
                dv.RowFilter = "category = '" + categoryFilter + "' and pcode = '" + pCode + "'";
            combobox.DataSource = dv;
            combobox.DisplayMember = "name";
            combobox.ValueMember = "code";
        }

        //int count;
        //TimeSpan span;
        private void Button1_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.AddSeconds(20);
            timer1.Start();
            //span = new TimeSpan(0, 0, 20);
            //timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            date = date.AddSeconds(-1);
            label1.Text = date.ToString("HH:mm:ss");

            DateTime ctime = DateTime.Now;
            if(ctime.Hour == date.Hour && ctime.Minute == date.Minute && ctime.Second == date.Second)
            {
                timer1.Stop();
            }

            //if (span.Seconds < 1)
            //    timer1.Stop();
            //span.Add(-new TimeSpan(0, 0, 1));
            //label1.Text = span.ToString("hh : mm : ss");
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonCodeBinding("M_TYPE", comboBox4, comboBox3.SelectedValue.ToString());
        }
    }
}
