using _0106_01_GoodeeShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace _0106_01_GoodeeShop
{
    public class ProductDAC
    {
        string strConn;
        public ProductDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        public List<Product> GetProducts(int page, int pageSize)
        {
            List<Product> list = new List<Product>();
            string sql = "GetProductsByPage";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@page", page);
                    comm.Parameters.AddWithValue("@pageSize", pageSize);

                    list = Helper_1230.Helper.DataReaderMapToList<Product>(comm.ExecuteReader());
                }
            }
            return list;
        }

        internal Product GetProductInfo(int productID)
        {
            throw new NotImplementedException();
        }

        public int GetProductTotalCount()
        {
            string sql = "SELECT count(*) FROM Products";
            int cnt = 0;
            using(SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    cnt = Convert.ToInt32(comm.ExecuteScalar());
                }
            }
            return cnt;
        }
    }
}