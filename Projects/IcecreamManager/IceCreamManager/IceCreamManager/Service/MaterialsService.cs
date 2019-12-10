using IceCreamManager.DAC;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.Service
{
   public class MaterialsService
    {
  
        public List<MaterialsVO> SelectAll()
        {
            MaterialsDAC dac = new MaterialsDAC();
    
            return dac.SelectAll();

        }
        public bool Insert(MaterialsVO list)
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.Insert(list);
        }
        /// <summary>
        /// 자제타입을가져온다
        /// </summary>
        /// <returns></returns>
        public List<MaterialsTypVO> Materials_Type()
        {
            MaterialsDAC dac = new MaterialsDAC();

            return dac.Materials_Type();
        }
    }
}
