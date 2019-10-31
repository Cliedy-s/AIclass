﻿using MachineProject.DAC;
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
    class PListByMachineService : IDisposable
    {
        MySqlConnection conn;
        PListByMachineDAC dac;
        public PListByMachineService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["MachineProjectConnStr"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
            dac = new PListByMachineDAC(conn);
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