﻿using System.Web;
using System.Web.Mvc;

namespace MVC2_Market
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
