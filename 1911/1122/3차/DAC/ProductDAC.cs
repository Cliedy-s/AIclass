using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp22.DAC
{
    public class ProductDAC:IDisposable
    {
        SqlConnection conn;

        public ProductDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null)
                conn.Close();
        }

        public List<ProductInfoVO> GetProductInfoList()
        {
            List<ProductInfoVO> list = null;

            StringBuilder sb = new StringBuilder();
            sb.Append("select ProductID, ProductName, p.SupplierID, ");
            sb.Append("       CompanyName, p.CategoryID, CategoryName, ");
            sb.Append("       QuantityPerUnit, UnitPrice ");
            sb.Append("  from Products p inner join Suppliers s on p.SupplierID = s.SupplierID ");
            sb.Append("                  inner join Categories c on p.CategoryID = c.CategoryID");

            SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            list = Helper.ConvertDataTableToList<ProductInfoVO>(dt);
            return list;
        }


    }
}
