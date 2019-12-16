using IceCreamManager.DAC;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.Service
{
    class CustomerOrderDetailService
    {
        public List<CustomerOrderDetailVO> SelectAll()
        {
            CustomerOrderDetailDAC dac = new CustomerOrderDetailDAC();
            return dac.SelectAll();
        }
        public List<CustomerOrderDetailVO> SelectAll(int cuoNo)
        {
            CustomerOrderDetailDAC dac = new CustomerOrderDetailDAC();
            return dac.SelectAll(cuoNo);
        }
        public List<CustomerOrderDetailProductConnectAllVO> SelectAllJoinProductName(int cuoNo)
        {
            CustomerOrderDetailDAC dac = new CustomerOrderDetailDAC();
            return dac.SelectAllJoinProductName(cuoNo);
        }
        
    }
}
