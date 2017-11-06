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

        public HomeController()
        {
            _productService = new ProductsService();
        }

        public ActionResult Index()
        {
            IEnumerable<Product> products = _productService.GetProducts();

            int listCount = products.Count(); 

            return View(listCount);
        }
    }
} 