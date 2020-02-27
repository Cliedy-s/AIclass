using _0123_01_CheckBox.DAC;
using _0123_01_CheckBox.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0123_01_CheckBox.Service
{
    class EmployeeService
    {
        public List<EmployeeInfoVO> GetAll()
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.GetAll();
        }
    }
}
