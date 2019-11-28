using _1125_ListLinqSample;
using _1125_ListLinqSampleVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_ListLinqSampleUI
{
    class EmployeeService
    {
        public bool RegisterEmployee(EmployeeVO emp)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.RegisterEmployee(emp);
        }
        public bool RegisterEmployeeSP(EmployeeVO emp)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.RegisterEmployeeSP(emp);
        }
        public List<EmployeeVO> GetAllEmployee( )
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.GetAllEmployee();
        }
        public EmployeeVO GetEmployeeById(int empID)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.GetEmployeeById(empID);
        }

        internal bool UpdateEmployee(EmployeeVO emp)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.UpdateEmployee(emp);
        }

        internal bool DeleteEmployee(int empID)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.DeleteEmployee(empID);
        }
    }
}
