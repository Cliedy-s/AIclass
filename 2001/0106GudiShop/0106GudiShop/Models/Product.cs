﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0106GudiShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}