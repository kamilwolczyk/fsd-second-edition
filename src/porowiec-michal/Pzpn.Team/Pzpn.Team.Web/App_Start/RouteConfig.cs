using System.Web.Mvc;
using System.Web.Routing;

namespace Pzpn.Team.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "{action}",
                defaults: new { controller = "Home", action = "Login" }
            );

            routes.MapRoute("players", 
                "players/{action}/{number}",
                new { controller="Player", number = UrlParameter.Optional}
            );
        }
    }
}
