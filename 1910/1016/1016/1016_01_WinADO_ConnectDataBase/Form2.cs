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
using MySql.Data.MySqlClient;

namespace _1016_01_WinADO_ConnectDataBase
{
    public partial class Form2 : Form
    {
        string goodieConnectionString = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            goodieConnectionString = ConfigurationManager.ConnectionStrings["LocalConnectionStringForGoodie"].ConnectionString;
            txtID.Focus();
            btnUpdate.Enabled = false;
            DataRetrieve();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(goodieConnectionString))
                {
                    string sql0 = " insert into members(userID, userPWD, userName) values(@userID, @userPWD, @userName); ";
                    string sql1 = string.Format(" insert into members(userID, userPWD, userName) values('{0}', '{1}', '{2}'); ", txtID.Text.Trim(), txtPwd.Text.Trim(), txtName.Text.Trim());
                    MySqlCommand command = new MySqlCommand(sql1, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("신규회원 등록", "회원등록 확인");
                DataRetrieve();
            }
            catch (Exception) { MessageBox.Show("오류!"); }
            finally { }
        }

        private void DataRetrieve(bool isAll = true, string name = "")
        {
            txtID.Enabled = true;
            StringBuilder sql1 = new StringBuilder(string.Format(" select userID, userPWD, userName from members where 1=1 "));
            if (!isAll)
            {
                sql1.Append(" and userName = '" + name + "' ");
            }
            using (MySqlConnection connection = new MySqlConnection(goodieConnectionString))
            {
                MySqlCommand command = new MySqlCommand(sql1.ToString(), connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                dataGridView1.DataSource = data;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                DataRetrieve();
            }
            else
            {
                DataRetrieve(false, txtName.Text);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            if (dataGridView1.DataSource is DataTable)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
                {
                    // txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtID.Text = dt.Rows[e.RowIndex]["userID"].ToString();
                    txtPwd.Text = dt.Rows[e.RowIndex]["userPWD"].ToString();
                    txtName.Text = dt.Rows[e.RowIndex]["userName"].ToString();

                    txtID.Enabled = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder(string.Format("update members set userPWD = '{1}', userName = '{2}' where userID = '{0}'; ", txtID.Text, txtPwd.Text, txtName.Text));
            using(MySqlConnection connection = new MySqlConnection(goodieConnectionString))
            {
                MySqlCommand command = new MySqlCommand(sql.ToString(), connection);

                connection.Open();
                int iresult = command.ExecuteNonQuery();
                if(iresult > 0) { MessageBox.Show("회원정보가 수정되었습니다."); }
                else { MessageBox.Show("수정할 정보가 없습니다."); }
            }
            DataRetrieve();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                if (MessageBox.Show("정말로 삭제하시겠습니까", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    StringBuilder sql = new StringBuilder(string.Format("delete from members where userID = '{0}'; ", txtID.Text));
                    using (MySqlConnection connection = new MySqlConnection(goodieConnectionString))
                    {
                        MySqlCommand command = new MySqlCommand(sql.ToString(), connection);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            DataRetrieve();
        }
    }
}
