﻿using System.Web;
using System.Web.Mvc;

namespace Jaskaran_C__Assignment1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
