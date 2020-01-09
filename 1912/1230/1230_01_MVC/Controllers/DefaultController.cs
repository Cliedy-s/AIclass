using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1230_01_MVC.Models;

namespace _1230_01_MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult welcome(string name, int id = 1)
        { // https://localhost:44318/Default/welcome
            ////return "Hellow " + name + id;
            ////ViewBag
            //ViewBag.Message = "Hello" + name;
            //ViewBag.NumTimes = id;

            ////Model 
            //Product product = new Product() {ProductID=1, ProductName="새우깡", QuantityPerUnit="열봉지" };
            //ViewBag.ProductInfo = product;
            //return View();

            // 강력한 형식의 뷰
            Product product = new Product() { ProductID = 1, ProductName = "새우깡", QuantityPerUnit = "열봉지" };
            ViewBag.ProductInfo = product;
            return View(product);
        }
        public ActionResult welcomeModelList(int id = 3)
        { // 값 여러개 전달
            ProductManager manager = new ProductManager();
            return View(manager.GetAllProductsByCategoryID(id));
        }
        
        [HttpGet]
        public ActionResult LoginView()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult LoginView(UserInfo user)
        {
            if(user.ID.Equals("Admin") && user.PWD.Equals("1234"))
            {
                user.Name = "관리자";
                return View("MainView", user); // 로그인 성공시 이동
            }
            return View();
        }

    }
}