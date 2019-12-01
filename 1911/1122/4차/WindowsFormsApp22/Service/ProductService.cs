using NorthWindDAC;
using NorthWindVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp22.Service
{
    public class ProductService
    {
        public List<ProductInfoVO> GetProductInfoList()
        {
            ProductDAC dac = new ProductDAC();
            List<ProductInfoVO> result = dac.GetProductInfoList();
            dac.Dispose();

            return result;
        }
    }
}
