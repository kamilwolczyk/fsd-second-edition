using System.Web.Mvc;
using System.Web.Routing;

namespace Fsd.Sebastian.Cs.Ex4.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Page", action = "Home" });
            routes.MapRoute("Products", "products", new { controller = "Products", action = "Products" });
            routes.MapRoute("Details", "products/details", new { controller = "Products", action = "Details" });
            routes.MapRoute("Add", "products/add", new { controller = "Products", action = "Add" });
            routes.MapRoute("About", "about", new { controller = "Page", action = "About" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Page", action = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
