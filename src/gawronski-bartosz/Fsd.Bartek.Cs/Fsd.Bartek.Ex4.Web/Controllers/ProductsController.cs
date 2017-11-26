using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Services.Services;
using Fsd.Bartek.Ex4.Services.Validation;
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
        private readonly IProductsService _sqlService;

        public ProductsController(IProductsService sqlService)
        {
            _sqlService = sqlService;
        }

        public ActionResult ProductsList(string page = null, string items = null)
        {
            ProductListModel list = new ProductListModel
            {
                Products = _sqlService.GetProducts(int.Parse(page ?? "0"), int.Parse(items ?? "0")).Select(entity => ProductMapping.ToProductModel(entity))
            };

            return View(list);
        }

        [ActionName("details")]
        public ActionResult ProductsDetails(int id)
        {
            return View(ProductWithoutIdMapping.ToProductWithoutIdModel(_sqlService.GetProductByIdNumber(id)));
        }

        [ActionName("edit")]
        public ActionResult EditProduct(int id)
        {
            return View(ProductWithoutIdMapping.ToProductWithoutIdModel(_sqlService.GetProductByIdNumber(id)));
        }

        [ActionName("add")]
        [HttpGet]
        public ActionResult AddProduct()
        {
            ProductAddModel newProduct = new ProductAddModel();

            return View(newProduct);
        }

        [ActionName("add")]
        [HttpPost]
        public ActionResult AddProduct(ProductAddModel newProduct)
        {
            if (!ModelState.IsValid)
                return View(newProduct);

            if (!DateValidator.DataChecker(newProduct.ProductionData))
            {
                ModelState.Clear();
                newProduct.AddFailed = true;
                return View(newProduct);
            }

            if (newProduct.Price == 0)
            {
                ModelState.Clear();
                newProduct.AddFailed = true;
                return View(newProduct);
            }

            _sqlService.AddProduct(newProduct.Producer, newProduct.Model, newProduct.Price, DateTime.Parse(newProduct.ProductionData), newProduct.Type);

            return RedirectToAction("ProductsList");
        }
    }
}