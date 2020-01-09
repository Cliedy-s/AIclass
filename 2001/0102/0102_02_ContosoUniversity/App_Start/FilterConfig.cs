using System.Web;
using System.Web.Mvc;

namespace _0102_02_ContosoUniversity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
