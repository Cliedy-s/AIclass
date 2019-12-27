using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForTest
{
    public partial class Write : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            string sql = "WriteReport";
            SqlConnection conn = new SqlConnection(@"server=192.168.0.5;uid=sa;pwd=1234;database=SampleDB;");

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@rpt_Name", txtReporter.Text.Trim());
            comm.Parameters.AddWithValue("@rpt_Title", txtTitle.Text.Trim());
            comm.Parameters.AddWithValue("@rpt_Contents", txtContents.Text.Trim().Replace("\r\n","<br/>"));

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("List.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }
    }
}