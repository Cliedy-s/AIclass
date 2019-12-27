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
    public partial class Read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int rptNo = Convert.ToInt32(Request.QueryString["No"]);

                string sql = "GetReport";
                SqlConnection conn = new SqlConnection(@"server=192.168.0.5;uid=sa;pwd=1234;database=SampleDB;");

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@rpt_No", rptNo);

                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    lblReporter.Text = reader["rpt_Name"].ToString();
                    lblTitle.Text = reader["rpt_Title"].ToString();
                    lblContents.Text = reader["rpt_Contents"].ToString();
                    lblDateTime.Text = Convert.ToDateTime(reader["rpt_DateTime"]).ToString("yyyy-MM-dd HH:mm");
                    lblEditDateTime.Text = Convert.ToDateTime(reader["rpt_EditDateTime"]).ToString("yyyy-MM-dd HH:mm");
                }
                conn.Close();
            }
        }
    }
}