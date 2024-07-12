﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NmhLesson08
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
    name: "NmhIndex",
    url: "NmhBooks/NmhIndex",
    defaults: new { controller = "NmhBooks", action = "NmhIndex" }
);

        }
    }
}
