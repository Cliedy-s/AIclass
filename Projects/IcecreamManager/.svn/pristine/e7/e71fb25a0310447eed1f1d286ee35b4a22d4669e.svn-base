using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IceCreamManager.DAC
{
    public class OffererDAC : DACParent
    {

        public bool IsIDValid(int id)
        {
            throw new NotImplementedException();
        }


        public List<OffererVO> SelectAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllOffereData";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<OffererVO> list = Helper.DataReaderMapToList<OffererVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public bool Insert(OffererVO list)
        {

            return true;
        }
        }
}
