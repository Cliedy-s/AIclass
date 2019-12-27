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
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllReportByPaging(1, 5);
            }
        }
        protected void grvReportTitles_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvReportTitles.PageIndex = e.NewPageIndex;
            GetAllReportByPaging(e.NewPageIndex + 1, 5);
        }
        private void GetAllReportByPaging(int pageNo, int pageSize)
        {
            string sql = "GetAllReportTitleByPaging";
            SqlConnection conn = new SqlConnection(@"server=192.168.0.5;uid=sa;pwd=1234;database=SampleDB;");

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@PageNo", pageNo);
            comm.Parameters.AddWithValue("@PageSize", pageSize);


            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();

            conn.Open();
            adapter.Fill(ds);
            conn.Close();

            grvReportTitles.PageSize = pageSize;
            grvReportTitles.VirtualItemCount = Convert.ToInt32(ds.Tables[1].Rows[0][0]);
            grvReportTitles.DataSource = ds.Tables[0];
            grvReportTitles.DataBind();
        }
    }
}