using System.Web;
using System.Web.Mvc;

namespace Fsd.Janus.Damian.Cs.Ex4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
