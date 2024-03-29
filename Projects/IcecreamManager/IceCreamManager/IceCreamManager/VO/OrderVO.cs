﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.VO
{
  public  class OrderVO
    {
        public int ofo_No { get; set; }// 발주코드
        public int ofo_Each { get; set; }//발주갯수
        public int mat_No { get; set; }//발주자재코드
        public int off_No { get; set; }//제조사코드
        public int cmt_No { get; set; }//주문타입코드
        public int ofo_Price { get; set; }//발주가격
        public DateTime ofo_Date { get; set; }//날짜
        public string cmt_Type { get; set; }//날짜
        public int mtt_No { get; set; }//자재타입


        /// <summary>
        /// //
        /// </summary>
        public string mat_Name { get; set; }//자재이름
  
        public string off_Name { get; set; }//제조사이름
        public string off_OwnerMobile { get; set; }//제조사 번호
        public string off_Addr { get; set; }//제조사 주소
        public string off_Manager { get; set; } //담당자 이름
        public string off_ManagerMobile { get; set; } //담당자 전화번호
      



    }

    public class OrderSubVO
    {
        public int mat_No { get; set; } //자재코드
        public string mat_Name { get; set; } //자재이름
        public int mat_Cost { get; set; } //자재 가격
        public int off_No { get; set; } //제조사코드
        public string off_Name { get; set; } //제조사이름
        public int mtt_No { get; set; }//자재타입


    }

}
