using IceCreamManager.DAC;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.Service
{
    class MaterialTypeService
    {
        /// <summary>
        /// 자제타입을가져온다
        /// </summary>
        public List<MaterialsTypeVO> Materials_Type()
        {
            MaterialTypeDAC dac = new MaterialTypeDAC();
            return dac.Materials_Type();
        }
    }
}
