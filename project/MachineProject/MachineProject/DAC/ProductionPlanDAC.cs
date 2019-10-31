using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.DAC
{
    class ProductionPlanDAC
    {
        MySqlConnection conn;
        public ProductionPlanDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }
        public DataTable SelectAll()
        {
            string sql = "SELECT ProductionPlanCode, ProductionID, TotalAmount FROM PRODUCTIONPLAN; ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.TableName = "PRODUCTIONPLAN";
            return dt;
        }
    }
}
