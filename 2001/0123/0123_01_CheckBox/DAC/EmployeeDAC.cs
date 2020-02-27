using _0123_01_CheckBox.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0123_01_CheckBox.DAC
{
    public class EmployeeDAC
    {
        string connstr = string.Empty;
        public EmployeeDAC()
        {
            connstr = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
        }
        public List<EmployeeInfoVO> GetAll()
        {
            List<EmployeeInfoVO> list = null;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(connstr);
                comm.CommandText =
@"SELECT [EmployeeID]
      ,[LastName]
      ,[FirstName]
      ,[Title]
  FROM [dbo].[Employees]; ";

                comm.Connection.Open();
                list =  Helper_1230.Helper.DataReaderMapToList<EmployeeInfoVO>(comm.ExecuteReader());
                comm.Connection.Close();
            }
            return list;
        }
    }
}
