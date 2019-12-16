﻿using System;
using System.Collections.Generic;
using IceCreamManager.VO;
namespace IceCreamManager.VO
{
    public class OffererVO 
    {
        public int off_No { get; set; } //제조사번호
        public string off_Name { get; set; }//제조사이름
        public string off_OwnerName { get; set; }//대표이름
        public string off_OwnerMobile { get; set; }//대표번호
        public string off_Manager { get; set; }//담당자이름
        public string off_ManagerMobile { get; set; }//담당자번호
        public string off_Addr { get; set; }//제조사주소

        public static implicit operator List<object>(OffererVO v)
        {
            throw new NotImplementedException();
        }
    }


}
