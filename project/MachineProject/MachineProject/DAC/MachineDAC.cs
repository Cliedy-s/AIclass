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
            string sql = string.Format("SELECT count(*) FROM MACHINE WHERE MachineID = @MachineID; ");
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
                    IsRunning = Convert.ToInt32(reader["isRunning"])
                };
                list.Add(dto);
            }
            return list;
        }
        public List<MachineDTO> SelectAll(string machindIDs)
        {
            List<MachineDTO> list = new List<MachineDTO>();
            string sql = string.Format("SELECT MachineID, isRunning FROM MACHINE WHERE 1=0 {0}; ", machindIDs);

            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();

            MachineDTO dto;
            while (reader.Read())
            {
                dto = new MachineDTO()
                {
                    MachineID = reader["MachineID"].ToString(),
                    IsRunning = Convert.ToInt32(reader["isRunning"])
                };
                list.Add(dto);
            }
            return list;
        }
        public bool GetRunState(string machineID)
        {
            string sql = "SELECT isRunning FROM MACHINE WHERE MachineID = @MachineID ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@MachineID", machineID);
            if (Convert.ToInt32(comm.ExecuteScalar()) == 1)
                return true;
            return false;
        }
        public int IsSomeMachineRunning()
        {
            string sql = "SELECT Count(*) FROM MACHINE WHERE isRunning = 1; ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            return Convert.ToInt32(comm.ExecuteScalar());
        }
    }
}
