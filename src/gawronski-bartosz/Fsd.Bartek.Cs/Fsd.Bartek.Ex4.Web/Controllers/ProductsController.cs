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

        // GET: Products
        public ActionResult ProductsList()
        {
            string page = Request.QueryString["page"];

            string items = Request.QueryString["items"];

            IEnumerable<Product> products = _productService.GetProducts();

            ProductListModel list;

            if (page == null && items == null)
            {
                list = new ProductListModel
                {
                    Products = products.Select(entity => new ProductModel
                    {
                        Producer = entity.Producer,
                        Model = entity.Model,
                        Price = entity.Price,
                        ProductionData = entity.ProductionData,
                        Type = entity.Type
                    })              
                };
            }
            else
            {
                throw new NotImplementedException();
            }

            return View(list);
        }
    }
}