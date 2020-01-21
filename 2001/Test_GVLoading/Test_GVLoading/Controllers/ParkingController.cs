using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_GVLoading.DAC;
using Test_GVLoading.Models;

namespace Test_GVLoading.Controllers
{
    public class ParkingController : Controller
    {
        public ActionResult Index(string returnUrl)
        {
            return View(new ParkedIndexViewModel() { Parking = GetParked(), ReturnUrl = returnUrl });
        }
        private Parking GetParked()
        {
            Parking park = (Parking)Session["Parking"];
            if (park == null)
            {
                park = new Parking();
                Session["Parking"] = park;
            }
            return park;
        }
        public ActionResult Summary()
        {
            return PartialView(GetParked());
        }
        public ActionResult Park(string GVCode, string returnUrl)
        {
            GVDAC product = new GVDAC();
            GV item = product.GetGVInfo(GVCode);

            GetParked().AddGV(item);
            return RedirectToAction("Index", new { returnUrl });
        }
        public ActionResult Out(string GVCode , string returnUrl)
        {
            GVDAC dac = new GVDAC();
            GV gv = dac.GetGVInfo(GVCode);

            GetParked().RemoveGV(gv);
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}