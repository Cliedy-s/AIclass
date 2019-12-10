using _1125_ListLinqSampleVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_ListLinqSample
{
    public class CommonDAC : ConnectionAccess
    {
        public List<ComboItemVO> GetCodeInfoByCodeTypes(string codeTypes, string separator)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetCodeInfoByCodeTypes2";
                cmd.Parameters.AddWithValue("@P_CodeTypes", codeTypes);
                cmd.Parameters.AddWithValue("@P_Separator", separator);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ComboItemVO> list = Helper.DataReaderMapToList<ComboItemVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public string LoginCheck(string firstName, string lastName)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoginCheck04";
                cmd.Parameters.AddWithValue("@I_FirstName", firstName);
                cmd.Parameters.AddWithValue("@I_LastName", lastName);
                cmd.Parameters.Add("@O_CheckResult", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                string sResult = cmd.Parameters["@O_CheckResult"].Value.ToString();
                cmd.Connection.Close();

                return sResult;
            }
        }
    }
}
