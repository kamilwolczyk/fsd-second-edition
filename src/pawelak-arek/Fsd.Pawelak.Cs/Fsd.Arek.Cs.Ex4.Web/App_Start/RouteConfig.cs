using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fsd.Arek.Cs.Ex4.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Home", action = "Index" });
            routes.MapRoute("Product", "Products/{action}", new { controller = "Product", action = "List" });
            routes.MapRoute("About", "About", new { controller = "Home", action = "About" });
            routes.MapRoute("Contact", "Contact", new { controller = "Home", action = "Contact" });
        }
    }
}
