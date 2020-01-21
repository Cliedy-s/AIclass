using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Test_GVLoading.Models;

namespace Test_GVLoading.DAC
{
    public class CategoryDAC
    {
        string strConn = string.Empty;
        public CategoryDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["WorkDB"].ConnectionString;
        }
        public List<Category> GetCategory()
        {
            List<Category> list = new List<Category>();
            string sql = "SELECT CategoryNo, CategoryName From Category";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Category() {CategoryNo=Convert.ToInt32(reader["CategoryNo"]), CategoryName=reader["CategoryName"].ToString() });
                    }
                }
            }
            return list;
        }
    }
}