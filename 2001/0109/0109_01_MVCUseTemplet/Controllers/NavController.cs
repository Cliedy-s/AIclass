using _0106GudiShop.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0106GudiShop.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public ActionResult Menu(string category=null)
        {
            ViewBag.SelectedCategory = category;
            ProductDAC product = new ProductDAC();
            List<string> categories = product.GetProductCategory();
            return PartialView(categories);
        }
    }
}