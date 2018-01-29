using System.Web;
using System.Web.Mvc;

namespace Fsd.Porowiec.Michal.Cs4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
