using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp22.DAC;

namespace WindowsFormsApp22.Service
{
    public class CustomerService
    {
        public List<CustomerVO> GetCustomerList()
        {
            CustomerDAC dac = new CustomerDAC();
            List<CustomerVO> result = dac.GetCustomerList();
            dac.Dispose();

            return result;
        }

        public List<ComboItemVO> GetCategoryRegionCodeList()
        {
            CustomerDAC dac = new CustomerDAC();
            List<ComboItemVO> result = dac.GetCategoryRegionCodeList();
            dac.Dispose();

            return result;
        }
    }
}
