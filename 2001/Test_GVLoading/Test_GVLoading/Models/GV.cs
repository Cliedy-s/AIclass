using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_GVLoading.Models
{
    public class GV
    {
        public string GVCode { get; set; }
        public int LoadCnt { get; set; }
        public int Capacity { get; set; }
        public int CategoryNo { get; set; }
        public string CategoryName { get; set; }
    }
}