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
        protected void Application_Start() // 서버가 시작할 때 실행한다.
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes); // 사용자 기본 설정정보 : App_Start > RouteConfig
            BundleConfig.RegisterBundles(BundleTable.Bundles); // css 불러오기 : Contents 아래 css들을 불러오는 메서드
        }
    }
}
