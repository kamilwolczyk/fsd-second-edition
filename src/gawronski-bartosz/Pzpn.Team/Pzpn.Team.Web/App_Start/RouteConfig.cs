using System.Web.Mvc;
using System.Web.Routing;

namespace Pzpn.Team.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("home", "{action}", new { controller = "Home", action = "Index"});

            routes.MapRoute("players", "players/{action}/{number}", new {controller = "Player", number = UrlParameter.Optional});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Player", action = "List", id = UrlParameter.Optional }
            );

        }
    }
}
