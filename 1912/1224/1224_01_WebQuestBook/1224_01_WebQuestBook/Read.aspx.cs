using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1224_01_WebQuestBook
{
    public partial class Read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idNo = Convert.ToInt32(Request.QueryString["id"]);

                string sql = "SELECT Name, Email, Title, Contents FROM guestbook WHERE id=@id; ";
                SqlConnection conn = new SqlConnection(@"server=192.168.0.5;uid=sa;pwd=1234;database=SampleDB;");

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", idNo);

                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    lblName.Text = reader["Name"].ToString();
                    lblTitle.Text = reader["Title"].ToString();
                    lblContents.Text = reader["Contents"].ToString();
                    lblEmail.Text = reader["Email"].ToString();
                }
                conn.Close();
            }
        }
    }
}