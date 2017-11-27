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


    }
}