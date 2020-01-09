using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _1231_01_MVC_Board
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() // ������ ������ �� �����Ѵ�.
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes); // ����� �⺻ �������� : App_Start > RouteConfig
            BundleConfig.RegisterBundles(BundleTable.Bundles); // css �ҷ����� : Contents �Ʒ� css���� �ҷ����� �޼���
        }
    }
}
