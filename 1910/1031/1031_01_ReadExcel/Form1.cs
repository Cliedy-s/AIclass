using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1031_01_ReadExcel
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
            connstr = ConfigurationManager.ConnectionStrings["employees"].ConnectionString;

            MySqlConnection conn = new MySqlConnection(connstr);
            string sql = "select * from departments; ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "departments");
            conn.Close();

            dataGridView1.DataSource = ds.Tables["departments"];
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AllowUserToResizeColumns = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Print Button
            // 미리보기
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            // printDocument1.Print(); //출력 -Document
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // DialogResult
            string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"; // 2007 전 파일
            string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"; // 2007 이후 파일 
            // : HDR ?  타이틀 포함? or not
            // : Data Source ? 파일 소스

            string filePath = openFileDialog1.FileName;
            string fileExtendsion = System.IO.Path.GetExtension(filePath);
            string connectionString = string.Empty;
            string sheetName = string.Empty;

            switch (fileExtendsion)
            {
                case ".xls": //97 - 03
                    connectionString = String.Format(Excel03ConString, filePath, "Yes");
                    break;
                case ".xlsx": //2007
                    connectionString = String.Format(Excel07ConString, filePath, "Yes");
                    break;
            }

            // 첫번째 시트의 이름을 가져온다.
            // 이름을 아는 경우에는 [Sheet$]로 한다. 이름을 모를 경우에 이 부분을 추가
            using(OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using(OleDbCommand comm = new OleDbCommand())
                {
                    comm.Connection = conn;
                    conn.Open();
                    DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dt.Rows[0]["TABLE_NAME"].ToString();
                    conn.Close();
                }
            }

            // 첫번째 시트의 데이터를 읽어서 dataGridView에 보이게 한다.
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter oda = new OleDbDataAdapter())
                {
                    DataTable dt = new DataTable();
                    oda.SelectCommand = new OleDbCommand("SELECT * FROM [" + sheetName + "]", conn);
                    //MessageBox.Show(sheetName);
                    //oda.SelectCommand = new OleDbCommand("SELECT * FROM [titanic_train$]"); //시트 네임을 알 경우
                    conn.Open();
                    oda.Fill(dt);
                    conn.Close();
                    dataGridView1.DataSource = dt;
                }
            }

        }
    }
}
