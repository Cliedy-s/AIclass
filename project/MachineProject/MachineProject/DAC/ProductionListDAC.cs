using MachineProject.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.DAC
{
    class ProductionListDAC
    {
        MySqlConnection conn;
        public ProductionListDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }
        public bool IsValid(string productionID, string machineID)
        {
            string sql = "SELECT Count(*) FROM PLISTBYMACHINE WHERE MachineID=@MachineID AND ProductionID = @ProductionID; ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@ProductionID", productionID);
            comm.Parameters.AddWithValue("@MachineID", machineID);

            if (Convert.ToInt32(comm.ExecuteScalar()) == 0)
                return false;
            return true;
        }
        public string SelectAll(string[,] machineAndTodo)
        {
            // sql 문
            StringBuilder sb = new StringBuilder();
            StringBuilder sbValues = new StringBuilder();
            sb.Append("SELECT ProductionCode, MachineID, ProductionID, TodoCode, EmployeeID, NormalAmount, DefectAmount, ProductionDate FROM PRODUCTIONLIST WHERE 1=0 ");

            for (int i = 0; i < machineAndTodo.GetLength(0); i++)
            {
                sbValues.Append(string.Format(" OR (MachineID = '{0}' AND TodoCode = {1}) ", machineAndTodo[i, 0], machineAndTodo[i, 1]));
            }
            sb.Append(sbValues.ToString() + "; ");

            return sb.ToString();
        }
        private void FillParameters(MySqlCommand comm, ProductionListDTO item)
        {
            comm.Parameters.AddWithValue("@ProductionCode", item.ProductionCode);
            comm.Parameters.AddWithValue("@MachineID", item.MachineID);
            comm.Parameters.AddWithValue("@ProductionID", item.ProductionID);
            comm.Parameters.AddWithValue("@TodoCode", item.TodoCode);
            comm.Parameters.AddWithValue("@EmployeeID", item.EmployeeID);
            comm.Parameters.AddWithValue("@NomalAmount", item.NomalAmount);
            comm.Parameters.AddWithValue("@DefectAmount", item.DefectAmount);
            comm.Parameters.AddWithValue("@ProductionDate", item.ProductionDate);
        }
    }
}
