using MachineProject.DTO;
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

        public List<TodoDTO> SelectAll()
        {
            List<TodoDTO> list = new List<TodoDTO>();
            string sql = "SELECT TodoCode, MachineID, ProductionID, EmployeeID, Amount, Complete, CompleteDate FROM TODO; ";

            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();

            TodoDTO dto;
            while (reader.Read())
            {
                dto = new TodoDTO()
                {
                    TodoCode = Convert.ToInt32(reader["TodoCode"]),
                    MachineID = reader["MachineID"].ToString(),
                    ProductionID = reader["ProductionID"].ToString(),
                    EmployeeID = reader["EmployeeID"].ToString(),
                    Amount = Convert.ToInt32(reader["Amount"]),
                    Complete = Convert.ToChar(reader["Complete"]),
                    CompleteDate = Convert.ToDateTime(reader["CompleteDate"])
                };
                list.Add(dto);
            }
            return list;
        }

        //public void Insert(TodoDTO item) {
        //}

        public void InsertNUpdateProductionPlan(TodoDTO item, int productionPlanCode, int planedAmount)
        {
            MySqlTransaction transaction = conn.BeginTransaction();

            try
            {
                // insert
                string insertsql = "INSERT INTO TODO(MachineID, ProductionID, EmployeeID, Amount) VALUES(@MachineID, @ProductionID, @EmployeeID, @Amount);";
                MySqlCommand insertcomm = new MySqlCommand(insertsql, conn);
                insertcomm.Transaction = transaction;
                FillParameters(insertcomm, item);
                insertcomm.ExecuteNonQuery();
                //

                //update
                string updatesql = "UPDATE PRODUCTIONPLAN SET PlanedAmount = PlanedAmount + @PlanedAmount WHERE ProductionPlanCode = @ProductionPlanCode; ";
                MySqlCommand updatecomm = new MySqlCommand(updatesql, conn);
                updatecomm.Transaction = transaction;
                updatecomm.Parameters.AddWithValue("@ProductionPlanCode", productionPlanCode);
                updatecomm.Parameters.AddWithValue("@PlanedAmount", planedAmount);
                updatecomm.ExecuteNonQuery();
                //

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }

        }

        public void FillParameters(MySqlCommand comm, TodoDTO item)
        {
            comm.Parameters.AddWithValue("@MachineID", item.MachineID);
            comm.Parameters.AddWithValue("@ProductionID", item.ProductionID);
            comm.Parameters.AddWithValue("@EmployeeID", item.EmployeeID);
            comm.Parameters.AddWithValue("@Amount", item.Amount);
        }


    }
}
