using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.DAC
{
    class PListByMachineDAC
    {
        MySqlConnection conn;
        public PListByMachineDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }
        public DataTable SelectAll()
        {
            string sql = "SELECT MachineID, ProductionID, AmountPerDay FROM PLISTBYMACHINE; ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.TableName = "PLISTBYMACHINE";
            return dt;
        }
    }
}
