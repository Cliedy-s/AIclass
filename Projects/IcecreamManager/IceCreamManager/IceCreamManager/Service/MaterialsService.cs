﻿using IceCreamManager.DAC;
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

        #region offerer
        public List<MaterialsVO> SelectAll()
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.SelectAll();
        }
        public bool Insert_Update(MaterialsVO list)
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.Insert_Update(list);
        }
        public List<MaterialsVO> SelectAllBOMExistingList()
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.SelectAllBOMExistingList();
        }

        internal List<MaterialsVO> SelectAllMaterialsNotExistInProduct()
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.SelectAllMaterialsNotExistInProduct();
        }

        /// <summary>
        /// 자제 삭제
        /// </summary>
        public bool Delete(int id)
        {

            MaterialsDAC dac = new MaterialsDAC();

            return dac.Delete(id);

        }
        #endregion



        public int Insert_Update_GetID(MaterialsVO vo)
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.Insert_Update_GetID(vo);
        }


        #region BOM
        public List<MaterialsBOMConnectVO> SelectAllChilds(List<int> parentValues)
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.SelectAllChilds(parentValues);
        }

        public List<MaterialsVO> SelectAllByIDsList(List<int> selectedValues)
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.SelectAllByIDsList(selectedValues);
        }


        #endregion
    }
}
