using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TempData
{
    public class EmployeesService : IDisposable
    {
        MySqlConnection conn;
        EmployeesDAC dac;
        public EmployeesService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["MachineProjectConnStr"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
            dac = new EmployeesDAC(conn);
        }
        public List<EmployeeDTO> SelectAll()
        {
            return dac.SelectAll();
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
