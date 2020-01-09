using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1230_01_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Action Method : 함수 1:1 뷰
            return View();
        }

        public ActionResult ViewPage1()
        {
            return View();
        }
    }
}