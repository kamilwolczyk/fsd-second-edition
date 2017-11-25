using System.Web.Mvc;
using System.Web.Routing;

namespace Fsd.Kamil.Cs.Ex5.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Site-about me", "about", new { controller = "Site", action = "About" });
            routes.MapRoute("Site-home", "home", new { controller = "Site", action = "Home" });
            routes.MapRoute("AllProducts", "products", new { controller = "Product", action = "Product" });
            routes.MapRoute("ProductList", "list", new { controller = "Product", action = "List" });
            routes.MapRoute("ProductAdd", "add", new { controller = "Product", action = "Add" });
            routes.MapRoute("ProductAddNew", "addnew", new { controller = "Product", action = "AddNew" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Site", action = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
