using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.VO
{
    public class ProductMaterialConnectVO
    {
        public int pro_No { get; set; }
        public string pro_Name { get; set; }
        public int pro_Price { get; set; }
        public byte[] pro_Img { get; set; }
        public int mat_No { get; set; }
        public string mat_Name { get; set; }
        public int mat_Each { get; set; }
        public int mat_Cost { get; set; }
        public int off_No { get; set; }
        public int mtt_No { get; set; }
        public int mat_MinSize { get; set; }
        public string mat_Unit { get; set; }
        public string mtt_Name { get; set; }
    }
}
