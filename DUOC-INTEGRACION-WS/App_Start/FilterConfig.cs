﻿using System.Web;
using System.Web.Mvc;

namespace DUOC_INTEGRACION_WS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
