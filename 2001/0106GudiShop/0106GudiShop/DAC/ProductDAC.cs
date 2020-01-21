using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using _0106GudiShop.Models;

namespace _0106GudiShop.DAC
{
    public class ProductDAC : IDisposable
    {
        string strConn = string.Empty;
        public ProductDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        public List<Product> GetProducts(int page, int pageSize, string category)
        {
            List<Product> list = new List<Product>();
            string sql = "GetProductList";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PAGE_NO", page);
                    cmd.Parameters.AddWithValue("@PAGE_SIZE", pageSize);
                    //방법1
                    if (category == null)
                        cmd.Parameters.AddWithValue("@CATEGORY", DBNull.Value); //DB에 널값을 주는 방법
                    else
                        cmd.Parameters.AddWithValue("@CATEGORY", category); //null 값을 잘 못받는다.
                                                                            //방법2
                                                                            //cmd.Parameters.AddWithValue("@CATEGORY", (category == null) ? string.Empty : category);

                    //SqlParameter param = new SqlParameter("@CATEGORY", SqlDbType.NVarChar);
                    //if (category == null) param.Value = DBNull.Value;
                    //else param.Value = category;
                    //cmd.Parameters.Add(param);

                    list = Helper.DataReaderMapToList<Product>(cmd.ExecuteReader());
                }
            }
            return list;
        }

        public int GetProductTotalCount(string category)
        {
            int iTotCount = 0;
            string sql = "select count(*) totCount from Products where (Category = @CATEGORY or ISNULL(@CATEGORY,'')='')";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (category == null)
                        cmd.Parameters.AddWithValue("@CATEGORY", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@CATEGORY", category);

                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }

        public List<string> GetProductCategory()
        {
            List<string> list = new List<string>();
            string sql = "SELECT DISTINCT Category From Products order by Category";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }
                }
            }
            return list;
        }

        public Product GetProductInfo(int productID)
        {
            List<Product> list = null;
            string sql = "SELECT ProductID, Name, Price, Description, Category FROM Products WHERE ProductID=@ProductID ";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    list = Helper.DataReaderMapToList<Product>(cmd.ExecuteReader());
                }
            }
            return (list == null) ? null :list[0];
        }

        public void Dispose()
        {

        }
    }
}