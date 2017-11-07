//using Fsd.Sebastian.Cs.Ex4.Data.Entities;
//using Fsd.Sebastian.Cs.Ex4.Services.Products;
//using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Mvc;

//namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
//{
//    public class ProductController : Controller
//    {
//        private IProductProvider _productProvider;

//        public ProductController()
//        {
//            _productProvider = new SampleProductProvider();
//        }

//        public ActionResult List()
//        {
//            IEnumerable<Product> products = _productProvider.GetAllProducts();

//            ProductListModel list = new ProductListModel
//            {
//                Products = products.Select(entity => new ProductModel
//                {
//                    Producer = entity.Producer,
//                    Model = entity.Model,
//                    Price = entity.Price,
//                    Date = entity.Date,
//                    Type = entity.Type
//                })
//            };

//            return View(list);
//        }
//    }
//}