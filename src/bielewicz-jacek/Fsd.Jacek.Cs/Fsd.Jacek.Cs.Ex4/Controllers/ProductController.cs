using Fsd.Jacek.Cs.Ex4.Data;
using Fsd.Jacek.Cs.Ex4.Models.Pageable;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Fsd.Jacek.Cs.Ex4.Models;

namespace Fsd.Jacek.Cs.Ex4.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult List(int? page, int? items)
        {
            int take = items ?? 10;
            int skip = page.HasValue ? (page.Value - 1) * take : 0;

            IEnumerable<ProductFrame> entities = _productService
                .GetAllProducts()
                .OrderByDescending(product => product.DateOfProduction);

            DataPart<ProductModel> model = DataPart<ProductModel>.GetPartFromEntities(entities, skip, take, MapEntityToModel);

            return View(model);
        }

        private ProductModel MapEntityToModel(ProductFrame entity)
        {
            return new ProductModel
            {
                Manufacterer = entity.Manufacterer,
                Model = entity.Model,
                Type = entity.Type,
                Price = entity.Price,
                ProductionDate = entity.DateOfProduction,
            };
        }
        /*
        private ProductModel GetNewModelByType(ProductType type)
        {
            switch (type)
            {
                case ProductType.Alkohol: return new AlkoholModel();
                case ProductType.Cigarets: return new CigaretsModel();
                case ProductType.Fish: return new FishModel();
                case ProductType.Fruits: return new FruitModel();
                case ProductType.Vegetable: return new VegetableModel();
            }

            return null;
        }
        */
    }
}