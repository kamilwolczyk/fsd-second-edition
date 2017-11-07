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
            return View();
        }

        public ActionResult AllProducts()
        {
            IEnumerable<Product> products = _productProvider.GetAllProducts();

            ProductListModel list = new ProductListModel
            {
                Products = products.Select(entity => new ProductModel
                {
                    Producer = entity.Producer,
                    Model = entity.Model,
                    Price = entity.Price,
                    Date = entity.Date,
                    Type = entity.Type
                })
            };

            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}