using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamManager.VO;
using IceCreamManager.DAC;
namespace IceCreamManager.Service
{
  public  class OrderService
    {

        public (List<OrderVO>, List<OrderSubVO>) SelectAll()

        {
            OrderDAC dac = new OrderDAC();
           

            return dac.SelectAll();

        }

        public bool Insert(OrderVO list)
        {
            OrderDAC dac = new OrderDAC();

            return dac.Insert(list);
        }

        public bool Update(int ofo_no, int cmt_no)
        {
            OrderDAC dac = new OrderDAC();

            return dac.Update(ofo_no, cmt_no);
        }

        /// <summary>
        /// 발주되어 입고된 자제 갯수 업데이트
        /// </summary>
        /// <returns></returns>
        public bool MaterialEachUpdate(int mat_No, int ofo_Each)
        {
            OrderDAC dac = new OrderDAC();

            return dac.MaterialEachUpdate(mat_No, ofo_Each);

        }
    }
}
