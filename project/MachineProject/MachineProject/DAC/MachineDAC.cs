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
    class MachineDAC
    {
        MySqlConnection conn;
        public MachineDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }
        public void UpdateRunState(string machineID, bool isRunning)
        {
            string sql = "UPDATE MACHINE SET isRunning = @isRunning WHERE MachineID = @MachineID;";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@MachineID", machineID);
            comm.Parameters.AddWithValue("@isRunning", isRunning ? 1 : 0);
            comm.ExecuteNonQuery();
        }


        public bool IsValid(string machineID)
        {
            string sql = string.Format("SELECT count(*) FROM EMPLOYEES WHERE MachineID = @MachineID; ");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MachineID", machineID);

            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }

        public List<MachineDTO> SelectAll()
        {
            List<MachineDTO> list = new List<MachineDTO>();
            string sql = "SELECT MachineID, isRunning FROM MACHINE; ";

            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();

            MachineDTO dto;
            while (reader.Read())
            {
                dto = new MachineDTO()
                {
                    MachineID = reader["MachineID"].ToString(),
                    IsRunning = Convert.ToBoolean(reader["isRunning"])
                };
                list.Add(dto);
            }
            return list;
        }
        //public DataTable SelectAll()
        //{
        //    DataTable data = new DataTable();
        //    data.TableName = "MACHINE";
        //    string sql = "SELECT MachineID, isRunning FROM MACHINE; ";

        //    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    return dt;
        //}
    }
}
