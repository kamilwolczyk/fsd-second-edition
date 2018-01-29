using Fsd.Arek.Cs.Ex4.Services.Services;
using Fsd.Arek.Cs.Ex4.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Arek.Cs.Ex4.Web.Controllers
{
    public class AdvertController : Controller
    {
        private IAdvertsServices _advertsServices;

        public AdvertController(IAdvertsServices advertsServices)
        {
            _advertsServices = advertsServices;
        }

        public ActionResult Display()
        {
            return PartialView(AdvertListToModelConverter.Convert(_advertsServices.GetAllAdverts()));
        }
    }
}