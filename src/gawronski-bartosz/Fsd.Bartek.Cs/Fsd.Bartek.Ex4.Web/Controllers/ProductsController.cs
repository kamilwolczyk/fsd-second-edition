using Fsd.Bartek.Ex4.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Bartek.Ex4.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsService _productService;
        
        public ProductsController()
        {
            _productService = new ProductsService();
        }

        // GET: Products
        public ActionResult ProductsList()
        {
            string page = Request.QueryString["page"];

            string items = Request.QueryString["items"];

            return View();
        }
    }
}