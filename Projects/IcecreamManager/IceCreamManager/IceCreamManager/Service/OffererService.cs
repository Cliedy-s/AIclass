using IceCreamManager.DAC;
using IceCreamManager.VO;
using System.Collections.Generic;
namespace IceCreamManager.Service
{
    public class OffererService
    {
        public List<OffererVO> GetAllOffereData()
        {
            OffererDAC dac = new OffererDAC();
            return dac.SelectAll();
        }

    
        public bool Insert(OffererVO list)
        {
            OffererDAC dac = new OffererDAC();
            return dac.Insert(list);
        }
    }
}
