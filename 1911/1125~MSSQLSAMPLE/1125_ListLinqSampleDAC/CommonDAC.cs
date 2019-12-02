using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1125_ListLinqSampleVO;

namespace _1125_ListLinqSample
{
    public class CommonDAC : ConnectionAccess
    {
        public List<ComboItemVO> GetCodeInfoByCodeTypes(string codeTypes, string separator)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetCodeInfoByCodeTypes_04";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@P_CodeTypes", codeTypes);
                comm.Parameters.AddWithValue("@P_Separator", separator);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ComboItemVO> vos = Helper.DataReaderMapToList<ComboItemVO>(reader);
                comm.Connection.Close();
                return vos;
            }
        }
    }
}
