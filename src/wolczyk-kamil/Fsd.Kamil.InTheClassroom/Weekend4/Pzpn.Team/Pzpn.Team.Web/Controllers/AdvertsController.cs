using Pzpn.Team.Web.Models.Adverts;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Pzpn.Team.Web.Controllers
{
    public class AdvertsController : Controller
    {
        public ActionResult Display()
        {
            return PartialView(new AdvertList
            {
                Items = new List<string>
                {
                    "Nike",
                    "Adidas"
                }
            });
        }
    }
}