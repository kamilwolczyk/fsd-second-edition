using Fsd.Kamil.Cs.Ex4.Data.Entities;
using Fsd.Kamil.Cs.Ex4.Data.Enums;
using Fsd.Kamil.Cs.Ex4.Services.Products;
using Fsd.Kamil.Cs.Ex4.Web.Models.Pageable;
using Fsd.Kamil.Cs.Ex4.Web.Models.Products;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Kamil.Cs.Ex4.Web.Controllers
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

            IEnumerable<ProductBase> entities = _productService
                .GetAllProducts()
                .OrderByDescending(product => product.ProductionDate);

            DataPart<ProductModel> model = DataPart<ProductModel>.GetPartFromEntities(entities, skip, take, MapEntityToModel);

            return View(model);
        }

        [HttpGet]
        public ActionResult Create(ProductType type)
        {
            return View(GetNewModelByType(type));
        }

        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            if (!ModelState.IsValid)
                return View(product);

            return RedirectToAction("Success", "Home", new { message = "Product has been created" });
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ProductBase product = _productService.GetById(id);
            return View(MapEntityToModel(product));
        }

        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {
            if (!ModelState.IsValid)
                return View(product);

            return RedirectToAction("Success", "Home", new { message = "Product has been updated" });
        }

        private ProductModel MapEntityToModel(ProductBase entity)
        {
            return new ProductModel
            {
                Producer = entity.Producer,
                Model = entity.Model,
                Type = entity.Type,
                Price = entity.Price,
                ProductionDate = entity.ProductionDate,
            };
        }

        private ProductModel GetNewModelByType(ProductType type)
        {
            switch (type)
            {
                case ProductType.Keyboard: return new KeyboardModel();
                case ProductType.Monitor: return new MonitorModel();
                case ProductType.Mouse: return new MouseModel();
                case ProductType.Notebook: return new NotebookModel();
                case ProductType.PC: return new PcModel();
                case ProductType.Phone: return new PhoneModel();
                case ProductType.Tablet: return new TabletModel();
            }

            return null;
        }
    }
}