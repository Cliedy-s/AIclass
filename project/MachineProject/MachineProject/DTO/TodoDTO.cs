using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.DTO
{
    public class TodoDTO
    {
        public int ProductionCode { get; set; }
        public string MachineID { get; set; }
        public string ProductionID{ get; set; }
        public string EmployeeID { get; set; }
        public int TotalAmount{ get; set; }
        public DateTime EndExpected{ get; set; }
    }
}
