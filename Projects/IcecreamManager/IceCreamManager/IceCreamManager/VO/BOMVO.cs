﻿namespace IceCreamManager.VO
{
    public class BOMVO
    {
        public int mat_ParentNo { get; set; } //부모번호   
        public int mat_ChildNo { get; set; } //자식번호
        public int bom_ChildEach { get; set; } //자식개수
        public string bom_ChildUnit { get; set; } //단위

    }

    public class BOMupdateVO
    {
        public int mat_ParentNo { get; set; } //부모번호
        public int mat_No { get; set; } //자재번호
        public string mat_Name { get; set; } //이름
        public int bom_ChildEach { get; set; } //자식개수
    }
    public class AmountVO
    {
        public int mat_No { get; set; }  //자재번호
        public int total_Cost { get; set; } //합계금액
        public int mat_Each { get; set; } //총자재개수
        public int mat_MinSize { get; set; } //안전재고량
        public string mat_Name { get; set; } //자재이름
        public string mat_Unit { get; set; } //자재단위
        public int mtt_No { get; set; } //제품단계코드
        public string mtt_Name { get; set; } //제품단계
        public int off_No { get; set; } //제조사번호
        public int total_each { get; set; } //구성자재개수
        public int mat_Cost { get; set; } //자재단가

        public AmountVO() {}
        public AmountVO(string mName, int matNo, string mtName, int tEach, int mEach, string mUnit, int mCost, int tCost, int offNo)
        {
            mat_No = matNo;
            mat_Name = mName;
            mtt_Name = mtName;
            total_each = tEach;
            mat_Each = mEach;
            mat_Unit = mUnit;
            mat_Cost = mCost;
            total_Cost = tCost;
            off_No = offNo;
        }
        public AmountVO(int matNo, string mName, string mtName, int mEach, int mSize, string mUnit, int mCost, int tCost)
        {
            mat_No = matNo;
            mat_Name = mName;
            mtt_Name = mtName;
            mat_Each = mEach;
            mat_MinSize = mSize;
            mat_Unit = mUnit;
            mat_Cost = mCost;
            total_Cost = tCost;
        }//부모
    }
}