using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.DAC
{
    class CustomerOrderDAC : DACParent
    {
        public List<CustomerOrderVO> SelectAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "SELECT [cuo_No], [cus_No], [cuo_Datetime], [cuo_TotalPrice] FROM [dbo].[CutomerOrder] ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<CustomerOrderVO> bomList = Helper.DataReaderMapToList<CustomerOrderVO>(reader);
                comm.Connection.Close();

                return bomList;
            }
        }
        public List<CustomerOrderVO> SelectAll(int cuoNo, DateTime from, DateTime to)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "  SELECT [cuo_No], [cus_No], [cuo_Datetime], [cuo_TotalPrice] FROM [dbo].[Customer_Order] WHERE cuo_No = @cuo_No AND cuo_Datetime BETWEEN @dtfrom AND @dtto; ";
                comm.CommandType = CommandType.Text;

                comm.Parameters.AddWithValue("@cuo_No", cuoNo);
                comm.Parameters.AddWithValue("@dtfrom", from.Date);
                comm.Parameters.AddWithValue("@dtto", to.Date);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<CustomerOrderVO> bomList = Helper.DataReaderMapToList<CustomerOrderVO>(reader);
                comm.Connection.Close();

                return bomList;
            }
        }
    }
}
