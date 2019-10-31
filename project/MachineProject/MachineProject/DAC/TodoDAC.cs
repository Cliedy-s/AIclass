using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.DAC
{
    class TodoDAC
    {
        MySqlConnection conn;
        public TodoDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }

        public DataTable SelectAll()
        {
            string sql = "SELECT TodoCode, MachineID, ProductionID, EmployeeID, TotalAmount FROM TODO; ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.TableName = "TODO";
            return dt;
        }
    }
}
