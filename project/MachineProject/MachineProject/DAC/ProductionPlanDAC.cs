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
    class ProductionPlanDAC
    {
        MySqlConnection conn;
        public ProductionPlanDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }
        public List<ProductionPlanDTO> SelectAll()
        {
            List<ProductionPlanDTO> list = new List<ProductionPlanDTO>();
            string sql = "SELECT ProductionPlanCode, ProductionID, TotalAmount FROM PRODUCTIONPLAN; ";

            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();

            ProductionPlanDTO dto;
            while (reader.Read())
            {
                dto = new ProductionPlanDTO()
                {
                    ProductionPlanCode = Convert.ToInt32(reader["ProductionPlanCode"]),
                    ProductionID = reader["ProductionID"].ToString(),
                    TotalAmount = Convert.ToInt32(reader["TotalAmount"])
                };
                list.Add(dto);
            }
            return list;
        }

        //public DataTable SelectAll()
        //{
        //    DataTable data = new DataTable();
        //    data.TableName = "PRODUCTIONPLAN";
        //        string sql = "SELECT ProductionPlanCode, ProductionID, TotalAmount FROM PRODUCTIONPLAN;";

        //        MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
        //        adapter.Fill(data);
        //        return data;
        //}
    }
}
