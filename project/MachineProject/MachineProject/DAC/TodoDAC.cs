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

        //public DataTable SelectAll(bool getByReader)
        //{
        //    DataTable data = new DataTable();
        //    data.TableName = "TODO";

        //    string sql = "SELECT TodoCode, MachineID, ProductionID, EmployeeID, TotalAmount FROM TODO; ";

        //    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
        //    adapter.Fill(data);
        //    return data;

        //}
    }
}
