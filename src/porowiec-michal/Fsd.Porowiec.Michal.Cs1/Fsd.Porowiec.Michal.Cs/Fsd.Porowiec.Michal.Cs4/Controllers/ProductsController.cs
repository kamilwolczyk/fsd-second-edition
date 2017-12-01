using Fsd.Porowiec.Michal.Cs4.Mappings;
using Fsd.Porowiec.Michal.Cs4.Models;
using Fsd.Porowiec.Michal.Data.Products;
using Fsd.Porowiec.Michal.Services.Warehouse;
using Fsd.Porowiec.Michal.Services.Warehouse.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Porowiec.Michal.Cs4.Controllers
{
    public class ProductsController: Controller
    {
        private readonly IWarehouseman _productService;

        public ProductsController(IWarehouseman warehouseman)
        {
            _productService = warehouseman;
        }

        public ActionResult Display(string page = null, string items = null)
        {
            ProductListModel model = new ProductListModel()
            {
                Products = _productService.GetProducts(int.Parse(page ?? "0"), int.Parse(items ?? "0")).Select(entity => new ProductModel
                {
                    Producer = entity.Producer,
                    Model = entity.Model,
                    Price = entity.Price,
                    DateOfProduction = entity.DateOfProduction,
                    Type = entity.Type
                })
            };

            return View("Products", model);
        }

        public ActionResult GetProduct(string model)
        {
            return View(ProductMapper.ToModel(_productService.GetProductByModel(model)));
        }

        [HttpGet]
        public ActionResult AddProduct ()
        {
            return View(new ProductModel());
        }

        [HttpPost]
        public ActionResult AddProduct (ProductModel product)
        {
            if(!ModelState.IsValid)
                return View(product);
            else
            {
                _productService.AddProduct(product.Model, product.Producer, product.Price, product.DateOfProduction, product.Type);

                return RedirectToAction("Display");
            }
        }
    }
}