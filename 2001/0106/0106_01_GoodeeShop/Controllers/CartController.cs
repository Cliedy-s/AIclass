using _0106_01_GoodeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0106_01_GoodeeShop.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(int productID, string returnUrl)
        {
            ProductDAC product = new ProductDAC();
            Product item = product.GetProductInfo(productID);


        }
    }
}