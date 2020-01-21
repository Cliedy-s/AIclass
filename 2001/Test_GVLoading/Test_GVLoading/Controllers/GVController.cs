using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_GVLoading.DAC;
using Test_GVLoading.Models;

namespace Test_GVLoading.Controllers
{
    public class GVController : Controller
    {
        // GET: Product
        int pageSize = 10;
        public ActionResult List(int? categoryno, int page = 1)
        {
            GVDAC gv = new GVDAC();
            GVListViewModel model = new GVListViewModel
            {
                GVs = gv.GetGVs(page, pageSize, categoryno),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = gv.GetGVTotalCount(categoryno)
                },
                CurrentCategory = categoryno
            };
            return View(model);
        }
    }
}