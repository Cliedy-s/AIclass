﻿using System.Web;
using System.Web.Mvc;

namespace _1230_02_MVC2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
