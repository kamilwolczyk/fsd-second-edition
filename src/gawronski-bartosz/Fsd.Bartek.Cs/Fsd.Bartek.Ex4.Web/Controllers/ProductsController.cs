using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Services.Services;
using Fsd.Bartek.Ex4.Web.Mappings;
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
        private readonly IProductsService _productService;

        public ProductsController(IProductsService productService)
        {
            _productService = productService;
        }

        public ActionResult ProductsList(string page = null, string items = null)
        {
            ProductListModel list = new ProductListModel
            {
                Products = _productService.GetProducts(int.Parse(page ?? "0"), int.Parse(items ?? "0")).Select(entity => ProductMapping.ToProductModel(entity))
            };

            return View(list);
        }

        [ActionName("details")]
        public ActionResult ProductsDetails(int id)
        {
            return View(ProductWithoutIdMapping.ToProductWithoutIdModel(_productService.GetProductByIdNumber(id)));
        }

        [ActionName("edit")]
        public ActionResult EditProduct(int id)
        {
           return View(ProductWithoutIdMapping.ToProductWithoutIdModel(_productService.GetProductByIdNumber(id)));
        }

        [ActionName("add")]
        public ActionResult AddProduct(int id)
        {
           //TODO: Tworzenie nowego produktu

            return View();
        }
    }
}