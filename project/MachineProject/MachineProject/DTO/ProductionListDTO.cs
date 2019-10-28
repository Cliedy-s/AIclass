using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.DTO
{
    public class ProductionListDTO
    {
        public int ProductionCode { get; set; }
        public string MachineID { get; set; }
        public string ProductionID { get; set; }
        public int TodoCode { get; set; }
        public string EmployeeID { get; set; }
        public int NomalAmount { get; set; }
        public int DefectAmount { get; set; }
        public DateTime ProductionDate { get; set; }

    }
}
