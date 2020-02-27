using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0128_01_DEVExpress_Report
{
    public partial class Form3 : Form
    {
        CheckBox headerCheckBox = new CheckBox();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SetDGV();
            GetDatas(true);
        }
        private void GetDatas(bool isinit)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mydbconn"].ConnectionString;
            string sql =
@"SELECT Right('00000' + cast([BarcodeID] as varchar), '5') as BarcodeID
	  ,p.[ProductID]
      ,p.ProductName
      ,[BoxLevel]
      ,[Qty]
      ,[Regdate]
  FROM [BarcodeOutput] as bo
    JOIN Products as p ON p.ProductID = bo.ProductID
  ORDER BY BarcodeID DESC ; ";
            DataSet ds1 = new DataSet();


            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds1, "BarcodeList");
                if (isinit)
                {
                    adapter = new SqlDataAdapter("select ProductID, ProductName from Products Order by ProductName; ", conn);
                    adapter.Fill(ds1, "ProductList");
                }
            }
            if (isinit)
            {
                comboBox1.DataSource = ds1.Tables["ProductList"];
                comboBox1.DisplayMember = "ProductName";
                comboBox1.ValueMember = "ProductID";
            }
            dataGridView1.DataSource = ds1.Tables["BarcodeList"];
        }
        private void SetDGV()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 2);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);


            AddNewColumnToDataGridView(dataGridView1, "바코드ID", "BarcodeID", true, 80);
            AddNewColumnToDataGridView(dataGridView1, "ProductID", "ProductID", true, 100);
            AddNewColumnToDataGridView(dataGridView1, "제품명", "ProductName", true, 100);
            AddNewColumnToDataGridView(dataGridView1, "포장레벨", "BoxLevel", true, 100);
            AddNewColumnToDataGridView(dataGridView1, "수량", "Qty", true, 200);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["chk"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }
        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility, int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn gridCol = new DataGridViewTextBoxColumn();
            gridCol.HeaderText = headerText;
            gridCol.DataPropertyName = dataPropertyName;
            gridCol.Width = colWidth;
            gridCol.Visible = visibility;
            gridCol.ValueType = typeof(string);
            gridCol.ReadOnly = true;
            gridCol.DefaultCellStyle.Alignment = textAlign;
            dgv.Columns.Add(gridCol);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((comboBox2.SelectedIndex + 1) * 10).ToString();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            List<string> chkEmpID = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["chk"].EditedFormattedValue);

                if (isCellChecked)
                {
                    chkEmpID.Add(row.Cells[1].Value.ToString());
                }
            }
            string chkbarcodeid = string.Join(", ", chkEmpID);

            string connstr = ConfigurationManager.ConnectionStrings["mydbconn"].ConnectionString;

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
@"SELECT Right('00000' + cast([BarcodeID] as varchar), '5') BarcodeID, ProductName, QuantityPerUnit, Qty
from BarcodeOutput bo, Products p
where bo.ProductID = p.ProductID
	and BarcodeID in ("+ chkbarcodeid + ") ORDER BY BarcodeID desc; ", conn);
                adapter.Fill(ds, "BarcodeList");
            }

            XtraReport2 rpt = new XtraReport2();
            rpt.DataSource = ds.Tables["BarcodeList"];

            Form2 frm = new Form2();
            frm.documentViewer1.DocumentSource = rpt;
            frm.ShowDialog();
            //ReportPreview frm = new ReportPreview(rpt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mydbconn"].ConnectionString;
            string sql =
@"INSERT INTO [dbo].[BarcodeOutput]
           ([ProductID]
           ,[BoxLevel]
           ,[Qty])
     VALUES
           (@ProductID
           ,@BoxLevel
           ,@Qty); ";

            using (SqlCommand comm = new SqlCommand(sql))
            {
                comm.Connection = new SqlConnection(connstr);

                comm.Parameters.AddWithValue("@ProductID", Convert.ToInt32(comboBox1.SelectedValue));
                comm.Parameters.AddWithValue("@BoxLevel", comboBox2.Text);
                comm.Parameters.AddWithValue("@Qty", Convert.ToInt32(textBox1.Text));
                comm.Connection.Open();
                comm.ExecuteNonQuery();
            }
            GetDatas(false);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["chk"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }
    }
}
