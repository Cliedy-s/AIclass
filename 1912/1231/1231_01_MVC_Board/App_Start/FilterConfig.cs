using System.Web;
using System.Web.Mvc;

namespace _1231_01_MVC_Board
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
