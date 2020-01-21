using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_GVLoading.DAC;
using Test_GVLoading.Models;

namespace Test_GVLoading.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public ActionResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            CategoryDAC dac = new CategoryDAC();
            List<Category> categories = dac.GetCategory();
            return PartialView(categories);
        }
    }
}