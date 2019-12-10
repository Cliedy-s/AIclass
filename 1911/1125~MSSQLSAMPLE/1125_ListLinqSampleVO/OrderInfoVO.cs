using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_ListLinqSampleVO
{
    public class OrderInfoVO
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public string ShipCompanyName { get; set; }
        public decimal? Freight { get; set; }
    }
}
