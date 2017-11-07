using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fsd.Sebastian.Cs.Ex4.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Home", action = "Index" });
            routes.MapRoute("Products", "products", new { controller = "Product", action = "List" });
            routes.MapRoute("About", "about", new { controller = "Home", action = "About" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
