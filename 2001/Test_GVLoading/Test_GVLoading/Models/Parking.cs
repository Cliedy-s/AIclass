using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_GVLoading.Models
{
    public class Parking
    {
        private List<GV> parked = new List<GV>();
        public List<GV> Parked { get { return parked; } }
        public void AddGV(GV gv)
        {
            Parked.Add(gv);
        }
        public void RemoveGV(GV gv)
        {
            Parked.RemoveAll(gvs => gvs.GVCode == gv.GVCode);
        }
        public void Clear()
        {
            Parked.Clear();
        }
        public int HeatGVCnt()
        {
            return Parked.Count<GV>(gv=>gv.CategoryNo==1);
        }
        public int DryGVCnt()
        {
            return Parked.Count<GV>(gv => gv.CategoryNo == 2);
        }
    }
}