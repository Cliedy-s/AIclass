using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace _1230_01_MVC.Models
{
    public class Product
    { // VO
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID {get;set; }
        public string QuantityPerUnit { get; set; }
    }

    public class ProductManager
    { //DAC
        public List<Product> GetAllProductsByCategoryID(int categoryID)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            List<Product> list;
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT ProductID, ProductName, CategoryID, QuantityPerUnit FROM Products WHERE CategoryID = @CategoryID";
                comm.Connection = conn;

                comm.Parameters.AddWithValue("@CategoryID", categoryID);

                conn.Open();
                SqlDataReader reader =  comm.ExecuteReader();
                list = Helper_1230.Helper.DataReaderMapToList<Product>(reader);
                conn.Close();

                return list;
            }
        }
    }
}