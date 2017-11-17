using Fsd.Porowiec.Michal.Cs4.Models;
using Fsd.Porowiec.Michal.Services.Warehouse;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Porowiec.Michal.Cs4.Controllers
{
    public class ProductsController: Controller
    {
        private Warehouseman _productService;

        public ProductsController()
        {
            _productService = new Warehouseman();
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