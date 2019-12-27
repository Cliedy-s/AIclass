using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1224_01_WebQuestBook
{
    public partial class Edit : System.Web.UI.Page
    {
        string pwd = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idNo = Convert.ToInt32(Request.QueryString["id"]);

                string sql = "SELECT Name, Email, Title, Contents, Pass FROM guestbook WHERE id=@id; ";
                SqlConnection conn = new SqlConnection(@"server=192.168.0.5;uid=sa;pwd=1234;database=SampleDB;");

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", idNo);

                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtTitle.Text = reader["Title"].ToString();
                    txtContents.Text = reader["Contents"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    pwd = reader["Pass"].ToString();
                    hidPwd.Value = reader["pass"].ToString();
                }
                conn.Close();
            }
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            if (hidPwd.Value == txtPass.Text)
            {
                // t수정
            }
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {

        }
    }
}