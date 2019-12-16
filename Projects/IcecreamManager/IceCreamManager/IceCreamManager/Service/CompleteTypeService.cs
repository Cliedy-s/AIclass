using IceCreamManager.DAC;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.Service
{
    class CompleteTypeService
    {
        public List<CompleteTypeVO> SelectAll()
        {
            CompleteTypeDAC dac = new CompleteTypeDAC();
            return dac.SelectAll();
        }
    }
}
