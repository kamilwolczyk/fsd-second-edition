using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Services.Services;
using Fsd.Bartek.Ex4.Web.Models;
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

        public ActionResult ProductsList(string page = null, string items = null)
        {
            //IEnumerable<Product> products = _productService.GetProducts();

            ProductListModel list = new ProductListModel
            {
                Products = _productService.GetProducts(int.Parse(page ?? "0"), int.Parse(items ?? "0")).Select(entity => new ProductModel
                {
                    Producer = entity.Producer,
                    Model = entity.Model,
                    Price = entity.Price,
                    ProductionData = entity.ProductionData,
                    Type = entity.Type
                })
            };

            return View(list);
        }
    }
}