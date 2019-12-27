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
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // auto Paging====================================
            //string sql = "SELECT [id],[Name],[Email],[Title],[Contents],[Pass] FROM [SampleDB].[dbo].[guestbook]; ";
            //SqlConnection conn = new SqlConnection(@"server=192.168.0.5;uid=sa;pwd=1234;database=SampleDB;");

            //SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            //DataTable dt = new DataTable();

            //conn.Open();
            //adapter.Fill(dt);
            //conn.Close();

            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            //=============================================


            // Custom Paging=====================================
            if (!IsPostBack)
            {
                GetGuestBookByCustomPage(1, 10);
            }
            //=============================================
        }
        private void GetGuestBookByCustomPage(int pageNo, int pageSize)
        {
            string sql = "GetGuestBookByCustomPage";
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

            GridView1.PageSize = pageSize;
            GridView1.VirtualItemCount = Convert.ToInt32(ds.Tables[1].Rows[0][0]);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // auto Paging====================================
            //GridView1.PageIndex = e.NewPageIndex;
            //GridView1.DataBind();
            //=============================================

            // Custom Paging=====================================
            GridView1.PageIndex = e.NewPageIndex;
            GetGuestBookByCustomPage(e.NewPageIndex+1, 10);
            //=============================================
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataView view = (GridView1.DataSource as DataTable).DefaultView;
            view.Sort = e.SortExpression;
            GridView1.DataSource = view;
            GridView1.DataBind();
            //GridView1.Sort(e.SortExpression, SortDirection.Ascending);
        }
    }
}