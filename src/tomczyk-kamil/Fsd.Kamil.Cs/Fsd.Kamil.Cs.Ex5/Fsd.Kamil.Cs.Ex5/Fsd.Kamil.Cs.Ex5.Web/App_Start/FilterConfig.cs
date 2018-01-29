using System.Web;
using System.Web.Mvc;

namespace Fsd.Kamil.Cs.Ex5.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
