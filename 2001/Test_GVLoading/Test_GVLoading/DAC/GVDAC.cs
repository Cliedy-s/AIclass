using Helper_1230;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Test_GVLoading.Models;

namespace Test_GVLoading.DAC
{
    public class GVDAC
    {
        string strConn = string.Empty;
        public GVDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["WorkDB"].ConnectionString;
        }
        public List<GV> GetGVs(int page, int pageSize, int? categoryno)
        {
            List<GV> list = new List<GV>();
            string sql = "GetGVList";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PAGE_NO", page);
                    cmd.Parameters.AddWithValue("@PAGE_SIZE", pageSize);

                    if (categoryno == null)
                        cmd.Parameters.AddWithValue("@CATEGORYNO", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@CATEGORYNO", categoryno);

                    list = Helper.DataReaderMapToList<GV>(cmd.ExecuteReader());
                }
            }
            return list;
        }
        public int GetGVTotalCount(int? categoryno)
        {
            int iTotCount = 0;
            string sql = "select count(*) totCount from GV where (CategoryNo = @CATEGORYNO or ISNULL(@CATEGORYNO,'')='')";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (categoryno == null)
                        cmd.Parameters.AddWithValue("@CATEGORYNO", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@CATEGORYNO", categoryno);

                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }
        public GV GetGVInfo(string GVCode)
        {
            List<GV> list = null;
            string sql = "SELECT GVCode, LoadCnt, Capacity, GV.CategoryNo, CategoryName FROM GV JOIN Category ON GV.CategoryNo = Category.CategoryNo WHERE GVCode=@GVCode ";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GVCode", GVCode);
                    list = Helper.DataReaderMapToList<GV>(cmd.ExecuteReader());
                }
            }
            return (list == null) ? null : list[0];
        }
    }
}