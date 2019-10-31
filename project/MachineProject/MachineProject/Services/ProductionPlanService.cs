using MachineProject.DAC;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.Services
{
    class ProductionPlanService
    {
        MySqlConnection conn;
        ProductionPlanDAC dac;
        public ProductionPlanService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["MachineProjectConnStr"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
            dac = new ProductionPlanDAC(conn);
        }

        public DataTable SelectAll()
        {
            return dac.SelectAll();
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
