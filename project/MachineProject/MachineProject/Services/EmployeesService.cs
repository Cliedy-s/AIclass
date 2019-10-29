using MachineProject.DAC;
using MachineProject.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject
{
    public class EmployeesService : IDisposable
    {
        MySqlConnection conn;
        EmployeesDAC dac;
        public EmployeesService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["memberInfo"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
            dac = new EmployeesDAC(conn);
        }

        public void Insert(EmployeeDTO item)
        {
            if (dac.IsValid(item.EmployeeID))
                throw new Exception(Properties.Resources.Error_EmpIDAlreadyExist_msg);
            if (dac.IsEmailExist(item.Email))
                throw new Exception(Properties.Resources.Error_EmpEmailAlreadyExist_msg);

            dac.Insert(item);
        }

        public void Update(EmployeeDTO item)
        {
            if (!dac.IsValid(item.EmployeeID))
                throw new Exception(Properties.Resources.Error_EmpIDNotExist_msg);

            dac.Update(item);
        }

        public void Delete(EmployeeDTO item)
        {
            if (!dac.IsValid(item.EmployeeID))
                throw new Exception(Properties.Resources.Error_EmpIDNotExist_msg);

            dac.Delete(item);
        }

        public EmployeeDTO SearchEmployee(string employeeID)
        {
            if (dac.IsValid(employeeID))
                throw new Exception(Properties.Resources.Error_EmpIDNotExist_msg);

            return dac.SearchEmployee(employeeID);
        }

        public List<EmployeeDTO> SelectAll()
        {
            return dac.SelectAll();
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
