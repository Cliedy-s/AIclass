using NorthWindVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindDAC
{
    public class CustomerDAC:IDisposable
    {
        SqlConnection conn;

        public CustomerDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }        

        public List<CustomerVO> GetCustomerList()
        {
            List<CustomerVO> list = null;

            string sql = "select CustomerID, CompanyName, ContactName, ContactTitle, Address, City from Customers";
            
            SqlCommand cmd = new SqlCommand(sql, conn);            
            SqlDataReader reader = cmd.ExecuteReader();
            list = Helper.DataReaderMapToList<CustomerVO>(reader);

            return list;
        }

        public List<ComboItemVO> GetCategoryRegionCodeList()
        {
            List<ComboItemVO> list = null;

            SqlCommand cmd = new SqlCommand("GetRegionCategoryID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            list = Helper.DataReaderMapToList<ComboItemVO>(reader);
            return list;
        }

        public void Dispose()
        {
            if (conn != null)
                conn.Close();
        }
    }
}
