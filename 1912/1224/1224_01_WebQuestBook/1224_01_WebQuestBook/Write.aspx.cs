using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace _1224_01_WebQuestBook
{
    public partial class Write : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtName.Text = "홍길동";
            }
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"server=192.168.0.5;uid=sa;pwd=1234;database=SampleDB;");

            //Response.Write("<script>alert('이것이 웹폼이다');</script>");
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into guestbook(Name, Email, Title, Contents, Pass) values (@Name, @Email, @Title, @Contents, @Pass); ";

            comm.Parameters.AddWithValue("@Name", txtName.Text);
            comm.Parameters.AddWithValue("@Email", txtEmail.Text);
            comm.Parameters.AddWithValue("@Title", txtTitle.Text);
            comm.Parameters.AddWithValue("@Contents", txtContents.Text);
            comm.Parameters.AddWithValue("@Pass", txtPass.Text);

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            //Response.Write("<script>alert('저장완료!');</script>");
            Response.Redirect("list.aspx");

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}