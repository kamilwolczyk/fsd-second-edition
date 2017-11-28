using Fsd.Sebastian.Cs.Ex4.Web.Models.Adverts;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
{
    public class AdvertsController : Controller
    {
        public ActionResult Display()
        {
            return PartialView(new AdvertListModel
            {
                Adverts = new List<string>
                {
                    "reklama 1",
                    "reklama 12",
                    "reklama 123",
                    "reklama 1234",
                }
            });
        }
    }
}