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
    class MachineService : IDisposable
    {
        MySqlConnection conn;
        MachineDAC dac;
        public MachineService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["MachineProjectConnStr"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
            dac = new MachineDAC(conn);
        }

        public void UpdateRunState(string machineID, bool isRunning)
        {
            if (!dac.IsValid(machineID))
                throw new Exception("기계아이디를 확인해주세요.");

            dac.UpdateRunState(machineID, isRunning);

        }
        public List<MachineDTO> SelectAll()
        {
            return dac.SelectAll();
        }
        public List<MachineDTO> SelectAll(string machineIDs)
        {
            return dac.SelectAll(machineIDs);
        }
        public bool GetRunState(string machineID)
        {
            return dac.GetRunState(machineID);
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
