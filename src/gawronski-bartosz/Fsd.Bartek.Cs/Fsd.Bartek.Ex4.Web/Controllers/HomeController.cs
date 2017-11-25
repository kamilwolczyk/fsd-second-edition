using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Bartek.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductsService _productService;

        private IProductsService _sqlServices;

        public HomeController(IProductsService productService, IProductsService sqlServices)
        {
            _productService = productService;

            _sqlServices = sqlServices;
        }

        public ActionResult Index()
        {
            IEnumerable<Product> products = _sqlServices.GetProducts(0, 0);

            int listCount = products.Count(); 

            return View(listCount);
        }
    }
} 