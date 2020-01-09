using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0106_01_GoodeeShop.Models
{
    public class ProductListView
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}