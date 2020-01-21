using _0106GudiShop.DAC;
using _0106GudiShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0106GudiShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        int pageSize = 10;
        public ActionResult List(string category, int page = 1)
        {
            ProductDAC product = new ProductDAC();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = product.GetProducts(page, pageSize, category),
                PagingInfo = new PagingInfo
                                {
                                    CurrentPage = page,
                                    ItemsPerPage = pageSize,
                                    TotalItems = product.GetProductTotalCount(category)
                                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}