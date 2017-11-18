using Fsd.Janus.Damian.Data.Entities;
using Fsd.Janus.Damian.Services.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Janus.Damian.Cs.Ex4.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController()
        {
            _productService = new FakeProductService();
        }

        public ActionResult Index()
        {
            int productsCount = _productService.GetProductsCount();

            return View(productsCount);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Site author Damian Janus";

            return View();
        }

    }
}