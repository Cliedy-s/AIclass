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
    class CompleteTypeDAC : DACParent
    {
        public List<CompleteTypeVO> SelectAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "SELECT [cmt_No], [cmt_Type] FROM [dbo].[CompleteType] ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<CompleteTypeVO> bomList = Helper.DataReaderMapToList<CompleteTypeVO>(reader);
                comm.Connection.Close();

                return bomList;
            }
        }
    }
}
