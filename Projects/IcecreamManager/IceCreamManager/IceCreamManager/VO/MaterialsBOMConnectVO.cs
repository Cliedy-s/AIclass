﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.VO
{
    public class MaterialsBOMConnectVO
    {
        public int mat_ParentNo { get; set; } //BOM 부모번호
        public int mat_ChildNo { get; set; } //BOM 자식번호
        public int bom_ChildEach { get; set; } //BOM 자식개수
        public string bom_ChildUnit { get; set; } //BOM 자식단위
        public int mat_No { get; set; } //자제코드
        public int off_No { get; set; }//제조사번호
        public string mat_Name { get; set; } //이름
        public int mat_Cost { get; set; }//가격
        public int mat_Each { get; set; }//개수
        public int mat_MinSize { get; set; }//마지노선
        public int mtt_No { get; set; } //자제타입
        public string mtt_Name { get; set; }//원제품./반제품/원재료
        public string mat_Unit { get; set; }//리터 개수
    }
}
