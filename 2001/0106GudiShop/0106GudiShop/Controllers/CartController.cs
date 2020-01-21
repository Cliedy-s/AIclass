using _0106GudiShop.DAC;
using _0106GudiShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0106GudiShop.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel() { Cart = GetCart(), ReturnUrl = returnUrl });
        }
        public ActionResult AddToCart(int productId, string returnUrl)
        {
            //ProductID에 해당하는 Product 조회
            ProductDAC product = new ProductDAC();
            Product item = product.GetProductInfo(productId);

            // 현재 세션에 있는 장바구니를 가져오기 위함
            GetCart().AddItem(item, 1);
            return RedirectToAction("Index", new { returnUrl });
        }
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        } // 현재 세션에 있는 장바구니를 가져오기 위함
        public ActionResult Summary()
        {
            return PartialView(GetCart());
        } // 장바구니 요약정보 (상단메뉴 우측)
        public ActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckOut(ShipInfo info)
        {
            //사용자가 로직상 체크
            if (GetCart().Lines.Count() < 1)
                ModelState.AddModelError("", "장바구니가 비었습니다.");
            if (ModelState.IsValid)
            {
                // 주문처리 ( 주문 완료 메일 발송 )
                DAC.EmailOrderProcessor send = new EmailOrderProcessor(new EmailSettings());
                send.ProcessOrder(GetCart(), info);

                // 장바구니 비워주기
                GetCart().Clear();

                return View("Completed");
            }
            return View();
        }
        public ActionResult RemoveFromCart(int ProductID, string returnUrl)
        {
            //ProductID에 해당하는 Product 조회
            ProductDAC product = new ProductDAC();
            Product item = product.GetProductInfo(ProductID);

            // 현재 세션에 있는 장바구니를 가져오기 위함
            GetCart().RemoveItem(item);
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}