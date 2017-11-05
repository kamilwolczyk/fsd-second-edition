using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Weekend3.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("user-list", "user/list", new { controller = "User", action = "List" });
            //routes.MapRoute("myRoute", "start/info", new { controller = "Home", action = "HelloWorld" });
            //routes.MapRoute("date", "date", new { controller = "Home", action = "Date" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
