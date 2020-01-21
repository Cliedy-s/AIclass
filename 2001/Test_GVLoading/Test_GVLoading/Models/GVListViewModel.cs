using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_GVLoading.Models
{
    public class GVListViewModel
    {
        public IEnumerable<GV> GVs { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int? CurrentCategory { get; set; }
    }
}