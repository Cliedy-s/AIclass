﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORTEST_02_DTO
{
    public class ProductionVO
    {
        public int Seq { get; set; }
        public int ProductID { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public int Quantity { get; set; }
        public int BadQuantity { get; set; }
    }
}
