using MachineProject.DAC;
using MachineProject.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.Services
{
    class ProductionListService
    {
        MySqlConnection conn;
        ProductionListDAC dac;
        public ProductionListService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["MachineProjectConnStr"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
            dac = new ProductionListDAC(conn);
        }
        public string SelectAll(string[,] machineAndTodo) //TODO - 되는지 확인하기
        {
            return dac.SelectAll(machineAndTodo);
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
