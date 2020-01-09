using _0106_01_GoodeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0106_01_GoodeeShop
{
    public class ProductController : Controller
    {
        int pageSize = 10;
        public ActionResult List(int page = 1)
        {
            ProductDAC dac = new ProductDAC();
            ProductListView model = new ProductListView()
            {
                Products = dac.GetProducts(page, pageSize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = dac.GetProductTotalCount()
                }
            };
            return View(model);
        }

    }
}