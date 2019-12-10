using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using IceCreamManager.VO;

namespace IceCreamManager.DAC
{
    public class ProductDAC : DACParent
    {

        public List<ProductVO> SelectAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllProduct";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader read = comm.ExecuteReader();
                List<ProductVO> list = Helper.DataReaderMapToList<ProductVO>(read);

                return list;
            }
        }
    }
}