using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Services.Products;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductProvider _productProvider;

        public HomeController()
        {
            _productProvider = new SampleProductProvider();
        }

        public ActionResult Index()
        {
            return View(_productProvider.GetProductsCount());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}