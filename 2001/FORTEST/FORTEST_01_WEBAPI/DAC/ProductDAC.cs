using FORTEST_02_DTO;
using Helper_1230;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace FORTEST_01_WEBAPI.DAC
{
    public class ProductDAC
    {
        string strConn = string.Empty;
        public ProductDAC()
        {
            this.strConn = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }
        public List<ProductVO> GetProducts()
        {
            string sql = "SELECT ProductID ,ProductName FROM Product_SSY; ";
            List<ProductVO> list = new List<ProductVO>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {

                    conn.Open();
                    list = Helper.DataReaderMapToList<ProductVO>(comm.ExecuteReader());
                }
            }
            return list;
        }
    }
}