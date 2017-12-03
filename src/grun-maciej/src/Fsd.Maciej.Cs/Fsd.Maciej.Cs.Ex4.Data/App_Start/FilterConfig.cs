using System.Web;
using System.Web.Mvc;

namespace Fsd.Maciej.Cs.Ex4.Data
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
