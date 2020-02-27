using System.Web;
using System.Web.Mvc;

namespace _0219_01_WebSimpleEIS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
