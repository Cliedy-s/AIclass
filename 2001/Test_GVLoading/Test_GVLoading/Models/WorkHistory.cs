using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_GVLoading.Models
{
    public class WorkHistory
    {
        public int WorkReq { get; set; }
        public GV HeatGVCode { get; set; }
        public int LoadCnt { get; set; }
        public DateTime WorkedDateTime { get; set; }

    }
}