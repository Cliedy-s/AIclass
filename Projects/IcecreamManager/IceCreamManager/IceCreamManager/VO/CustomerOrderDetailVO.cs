﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.VO
{
    public class CustomerOrderDetailProductConnectVO
    {
        public int pro_No { get; set; }
        public string pro_Name { get; set; }
        public string pro_SizeString { get; set; }
        private int size;
        public int pro_Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (pro_Size)
                {
                    case 1:
                        pro_SizeString = "주니어";
                        break;
                    case 2:
                        pro_SizeString = "레귤러";
                        break;
                    case 3:
                        pro_SizeString = "킹";
                        break;
                }
            }
        }
        public int cod_Each { get; set; }
        public int cod_Price { get; set; }
    }
    public class CustomerOrderDetailVO
    {
        public int cod_No { get; set; }
        public int cuo_No { get; set; }
        public int pro_No { get; set; }
        public int cod_Each { get; set; }
    }
    class CustomerOrderDetailProductConnectAllVO
    {
        public int cod_No { get; set; }
        public int cuo_No { get; set; }
        public int pro_No { get; set; }
        public int cod_Each { get; set; }
        public int pro_Name { get; set; }
        public int mat_No { get; set; }
        public int pro_Price { get; set; }
    }
}
