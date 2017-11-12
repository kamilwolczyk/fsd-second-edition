using System.Web;
using System.Web.Mvc;

namespace Fsd.Artur.Cs4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
