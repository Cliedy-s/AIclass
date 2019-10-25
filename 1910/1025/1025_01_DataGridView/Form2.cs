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

namespace _1025_01_DinamicControls
{
    public partial class Form2 : Form
    {
        string connstr;
        DataSet dataSet;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connstr = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //1
            DataGridViewCheckBoxColumn ckc = new DataGridViewCheckBoxColumn();
            ckc.Width = 30;
            ckc.HeaderText = "";
            ckc.Name = "cbc";
            dataGridView1.Columns.Add(ckc);

            DataGridViewAddColumns.DataGridViewAddColumnes cadd = new DataGridViewAddColumns.DataGridViewAddColumnes();
            cadd.AddNewColumnToDataGridView("productID", "productID", dataGridView1, typeof(int), 80); //2
            cadd.AddNewColumnToDataGridView("제품명", "productName", dataGridView1, typeof(string), 200); //3

            DataGridViewButtonColumn bc = new DataGridViewButtonColumn(); //3
            bc.HeaderText = "";
            bc.Text = "수정";
            bc.Name = "btnEdit";
            bc.Width = 50;
            bc.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bc);

            bc = new DataGridViewButtonColumn(); //4
            bc.HeaderText = "";
            bc.Text = "삭제";
            bc.Name = "btnDelete";
            bc.Width = 50;
            bc.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bc);

            DataGridViewComboBoxColumn cbc = new DataGridViewComboBoxColumn(); //5
            cbc.HeaderText = "선택";
            cbc.Items.Add("일반회원");
            cbc.Items.Add("관리자");
            cbc.DefaultCellStyle.Padding = new Padding(0, 15, 0, 15);
            dataGridView1.Columns.Add(cbc);

            DataGridViewImageColumn ic = new DataGridViewImageColumn(); //6
            ic.Name = "imageColumne";
            ic.Image = Image.FromFile(@"D:\AIclass\sources\딸기.png");
            ic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            // ic.DataPropertyName = "productImgFileName";
            dataGridView1.Columns.Add(ic);

            dataGridView1.RowTemplate.Height = 50; // 높이 수정

            DataRetrieve();

            dataGridView1.Rows[1].Cells[0].Value = true;
        }
        private void DataRetrieve()
        {
            dataSet = new DataSet();
            MySqlConnection conn = new MySqlConnection(connstr);

            string sql = "select productID, productName from product";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            conn.Open();
            adapter.Fill(dataSet, "product");
            conn.Close();

            dataGridView1.DataSource = dataSet.Tables["product"];
            dataGridView1.ClearSelection();
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Color firstcolor = Color.White;
            Color secondcolor = Color.LightGray;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = firstcolor;
                else dataGridView1.Rows[i].DefaultCellStyle.BackColor = secondcolor;

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < 3)
                {
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = secondcolor;
                    dataGridView1.Rows[i].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Red, BackColor = Color.Yellow };
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 체크됐는지 확인하는 버튼
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow gvr = dataGridView1.Rows[e.RowIndex];
                //string msg = string.Format("수정 - PID : {0}, Pname : {1}, Check?  {2}"
                //    , dataGridView1.Rows[e.RowIndex].Cells[1].Value
                //    , dataGridView1.Rows[e.RowIndex].Cells[2].Value
                //    , dataGridView1.Rows[e.RowIndex].Cells[0].Value );
                string msg = string.Format("수정 - PID : {0}, Pname : {1}, Check?  {2}"
                    , gvr.Cells[1].Value
                    , gvr.Cells[2].Value
                    , gvr.Cells[0].Value);
                MessageBox.Show(msg);
            }
            else if (e.ColumnIndex == 4)
            {
                DataGridViewRow gvr = dataGridView1.Rows[e.RowIndex];
                string msg = string.Format("삭제 - PID : {0}, Pname : {1}, Check?  {2}"
                    , gvr.Cells[1].Value
                    , gvr.Cells[2].Value
                    , gvr.Cells[0].Value);
                MessageBox.Show(msg);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataSet = new DataSet();
            MySqlConnection conn = new MySqlConnection(connstr);

            string sql = "select a.productID, a.productName, b.productImage from product a inner join ( select productID, productImage from productimage where productImage is not null ) as b on a.productID = b.productID order by  a.productName; ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            conn.Open();
            adapter.Fill(dataSet, "product");
            conn.Close();

            dataGridView1.DataSource = dataSet.Tables["product"];
            dataGridView1.ClearSelection();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            string sql = "select a.productID, a.productName, b.productImgFileName from product a inner join ( select productID, productImgFileName from productimage where productImage is null ) as b on a.productID = b.productID order by  a.productName; ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();

            dataGridView1.DataSource = dt;

            Image img;
            int i = 0;
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                img = Image.FromFile(Application.StartupPath.Replace("\\", "/") + "/" + dt.Rows[i]["productImgFileName"].ToString());
                dataGridView1.Rows[j].Cells[6].Value = img;
                j++;
            }
           // dataGridView1.ClearSelection();
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true; // 파란색으로 선택
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[1]; // 화살표가 움직여야해서 줌
                contextMenuStrip1.Show(dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void Path부르기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 수정
            int selectedidx= dataGridView1.CurrentCell.RowIndex;
            string msg = string.Format("수정 - PID : {0}, Pname : {1}, Check?  {2}"
                , dataGridView1.Rows[selectedidx].Cells[1].Value
                , dataGridView1.Rows[selectedidx].Cells[2].Value
                , dataGridView1.Rows[selectedidx].Cells[0].Value);
            MessageBox.Show(msg);
        }
    }
}
