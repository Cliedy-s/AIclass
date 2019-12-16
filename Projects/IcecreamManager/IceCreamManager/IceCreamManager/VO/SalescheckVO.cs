using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.VO
{
    public class SalescheckMVO //제품 전체 판매금액, 제품별판매금액
    {
        public int pro_No { get; set; } //제품코드
      public string pro_Name { get; set; }//제품이름
        public int cod_Each { get; set; }//개수
        public int pro_Price { get; set; }//가격
}
    public class SalescheckCVO
    {
       public int cus_No{ get; set; } //회원코드
    public string cus_Name{ get; set; }//회원이름
public int pro_No { get; set; }
        public string pro_Name { get; set; }
        public int cod_Each { get; set; }
        public int pro_Price { get; set; }
    }
}
