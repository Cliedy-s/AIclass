using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1024_01_ImageToDB
{
    public partial class Form1 : Form
    {
        string connstr = string.Empty;
        DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connstr = ConfigurationManager.ConnectionStrings["imageadd"].ConnectionString;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewAddColumns.DataGridViewAddColumnes cadd = new DataGridViewAddColumns.DataGridViewAddColumnes();
            cadd.AddNewColumnToDataGridView("productID", "productID", dataGridView1, typeof(int), 80, null, false);
            cadd.AddNewColumnToDataGridView("제품명", "productName", dataGridView1, typeof(string), 200);

            DataRetrieve();
        }

        private void DataRetrieve()
        {

            dataSet = new DataSet();
            MySqlConnection conn = new MySqlConnection(connstr);

            string sql = "select productID, productName from product";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            conn.Open();
            adapter.Fill(dataSet, "product");

            dataGridView1.DataSource = dataSet.Tables["product"];

            sql = "select productImgID, productID, IFNULL(productImgFileName, 'BLOB이미지') as productImgFileName from productimage order by productID, productImgID; ";
            adapter.SelectCommand.CommandText = sql;
            adapter.Fill(dataSet, "productImage");
            conn.Close();


            txtProductID.Text = "";
            txtProductName.Text = "";
            pictureBox1.Image = null;
            dataGridView1.ClearSelection();
            listBox1.Items.Clear();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dataSet.Tables["product"].Rows.Count)
            {
                txtProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtProductID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                // 등록된 이미지 리스트박스에 보여주기
                listBox1.Items.Clear();
                DataView dv = new DataView(dataSet.Tables["productImage"]);
                dv.RowFilter = "productID = " + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                for (int i = 0; i < dv.Count; i++)
                {
                    listBox1.Items.Add(dv[i]["productImgFileName"].ToString());
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 이미지 삭제
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("삭제할 이미지를 선택해 주십시오");
                return;
            }
            if (MessageBox.Show("정말로 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string path = listBox1.SelectedItem.ToString();
                try
                {
                    //id 주면 더 좋음
                    string sql = string.Format("DELETE FROM productImage WHERE productImgFileName = '{0}'; ", path);
                    using (MySqlConnection conn = new MySqlConnection(connstr))
                    {
                        MySqlCommand comm = new MySqlCommand(sql, conn);
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    string destFile = Path.Combine(Environment.CurrentDirectory.Replace("\\", "/"), path);
                    MessageBox.Show(destFile);
                    if (File.Exists(destFile))
                    {
                        File.Delete(destFile);
                    }

                    DataRetrieve();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    Debug.WriteLine(ee);
                }
                finally
                {

                }
            }
        } // 이미지 삭제
        private void Button2_Click(object sender, EventArgs e)
        {
            if(!(txtProductName.TextLength >1))
            {
                MessageBox.Show("제품을 선택해 주세요");
                return;
            }
            AddImageForm frm = new AddImageForm(txtProductID.Text, txtProductName.Text);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                DataRetrieve();
            }
        } // 이미지 추가

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count >0)
            {
                string filePath = listBox1.SelectedItem.ToString();

                if(filePath.Equals("BLOB이미지") || filePath.Length < 1)
                {
                    LoadBLOBImage();
                    return;
                }

                // 1. 메모리로 이미지 주기
                //MemoryStream ms = new MemoryStream(File.ReadAllBytes(Application.StartupPath + "/" + filePath));
                //pictureBox1.Image = Image.FromStream(ms);
                // 2.
                pictureBox1.ImageLocation = filePath;
                // 3. delete시 오류
                // pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory+"\\"+listBox1.SelectedItem.ToString().Replace("/", "\\"));
                // pictureBox1.Image = Image.FromFile(Application.StartupPath+ "/" + listBox1.SelectedItem.ToString());

            }
        }

        private void LoadBLOBImage()
        {
            using(MySqlConnection conn = new MySqlConnection(connstr))
            {
                string sql = "select productImage from productimage where productImgFileName is null and productID = " + txtProductID.Text;
                DataTable dt = new DataTable();

                conn.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(dt);

                byte[] bits;
                bits = (byte[])dt.Rows[0][0];
                MemoryStream ms = new MemoryStream(bits);
                this.pictureBox1.Image = Bitmap.FromStream(ms);
            }
        }

    }
}
