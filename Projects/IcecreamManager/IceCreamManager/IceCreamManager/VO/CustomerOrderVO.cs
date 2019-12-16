using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.VO
{
    public class CustomerOrderVO
    {
        public int cuo_No { get; set; } //주문코드
        public int cus_No { get; set; }//고객코드
        public DateTime cuo_Datetime { get; set; } //날짜
        public int cuo_TotalPrice { get; set; }//총가격
    }
}
