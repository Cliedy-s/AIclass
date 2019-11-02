using MachineProject.DAC;
using MachineProject.DTO;
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
    class TodoService : IDisposable
    {
        TodoDAC dac;
        MySqlConnection conn;
        public TodoService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["MachineProjectConnStr"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
            dac = new TodoDAC(conn);
        }
        public List<TodoDTO> SelectAll()
        {
            return dac.SelectAll();
        }

        public void InsertNUpdateProductionPlan(TodoDTO item, int productionPlanCode, int planingAmount)
        {
            ProductionListDAC pldac = new ProductionListDAC(conn);
            if (!pldac.IsValid(item.ProductionID, item.MachineID))
                throw new Exception(Properties.Resources.Error_NoProductable_msg);

            ProductionPlanDAC ppdac = new ProductionPlanDAC(conn);
            if (!ppdac.IsAddable(productionPlanCode, planingAmount))
                throw new Exception(Properties.Resources.Error_ProductionPlanNotAddable_msg);

            dac.InsertNUpdateProductionPlan(item, productionPlanCode, planingAmount);
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
