using System.Web.Mvc;
using System.Web.Routing;

namespace Pzpn.Team.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("players", "players/{action}/{number}", new { controller = "Player", number = UrlParameter.Optional });
            routes.MapRoute("site-contact", "contact", new { controller = "Site", action = "Contact" });
            routes.MapRoute("site-home", "", new { controller = "Site", action = "Home" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Player", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}
