﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamManager.VO;
using IceCreamManager.DAC;
namespace IceCreamManager.Service
{
    public class SalescheckService
    {
        /// <summary>
        /// 전체 제품 , 제품별판매금액
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="check"></param>
        /// <returns></returns>
        public List<SalescheckMVO> SelectAllM(string start, string end, int check)
        {
            SalescheckDAC dac = new SalescheckDAC();

            return dac.SelectAllM(start, end, check);
        }

        /// <summary>
        /// 횡원별
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<SalescheckCVO> SelectAllC(string start, string end)
        {
            SalescheckDAC dac = new SalescheckDAC();

            return dac.SelectAllC(start, end);
        }

        public List<UserVO> SelectUser()
        {
            SalescheckDAC dac = new SalescheckDAC();

            return dac.SelectUser();
        }

     
    }
}
