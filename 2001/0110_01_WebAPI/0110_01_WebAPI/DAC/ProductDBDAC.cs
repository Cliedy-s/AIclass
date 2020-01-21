using ProductDTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ProductDTO.DAC
{
    public class ProductDBDAC : IDisposable
    {
        private string strConn = string.Empty;

        public ProductDBDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        /// <summary>
        /// 카테고리별 현재 페이지에 해당하는 제품 목록 조회
        /// </summary>
        /// <param name="page">페이지 번호</param>
        /// <param name="pageSize">페이지 크기</param>
        /// <param name="category">카테고리 선택</param>
        /// <returns></returns>
        public List<ProductDB> GetProducts(int page, int pageSize, string category)
        {
            List<ProductDB> list = new List<ProductDB>();
            string sql = "GetProductsByPage";

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

                    list = Helper.DataReaderMapToList<ProductDB>(cmd.ExecuteReader());
                }
            }
            return list;
        }

        /// <summary>
        /// 카테고리별 전체 제품건수 조회
        /// </summary>
        /// <param name="category">레노버...</param>
        /// <returns>카테고리 전체 제품건수</returns>
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

        /// <summary>
        /// 등록된 제품의 카테고리 목록 조회
        /// </summary>
        /// <returns>카테고리 목록</returns>
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
                    while (reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// id에 해당하는 제품 상세정보 조회
        /// </summary>
        /// <param name="productID">제품 아이디</param>
        /// <returns>제품 vo</returns>
        public ProductDB GetProductInfo(int productID)
        {
            List<ProductDB> list = null;
            string sql = "SELECT ProductID, Name, Price, Description, Category FROM Products WHERE ProductID=@ProductID ";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    list = Helper.DataReaderMapToList<ProductDB>(cmd.ExecuteReader());
                }
            }
            return (list == null) ? null : list[0];
        }

        public bool InsertProduct(ProductDB product)
        {
            string sql = "INSERT INTO [dbo].[Products] ([Name] ,[Price] ,[Description] ,[Category]) VALUES (@Name ,@Price ,@Description ,@Category); ";
            int result = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.Parameters.AddWithValue("@Category", product.Category);

                    result = cmd.ExecuteNonQuery();
                }
            }
            return result > 0;
        }

        public bool UpdateProduct(int id, ProductDB product)
        {
            string sql = "UPDATE [dbo].[Products] SET Name = @Name , Price =@Price , Description = @Description , Category = @Category WHERE ProductID = @ProductID; ";
            int result = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.Parameters.AddWithValue("@Category", product.Category);
                    cmd.Parameters.AddWithValue("@ProductID", id);

                    result = cmd.ExecuteNonQuery();
                }
            }
            return result > 0;
        }

        public bool DeleteProduct(int id)
        {
            string sql = "DELETE FROM [dbo].[Products] WHERE ProductID = @ProductID; ";
            int result = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result > 0;
        }

        public bool IsExist(int id)
        {
            string sql = "SELECT count(*) FROM Products WHERE ProductID=@ProductID; ";
            int result = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return result > 0;
        }

        public void Dispose()
        {
        }
    }
}