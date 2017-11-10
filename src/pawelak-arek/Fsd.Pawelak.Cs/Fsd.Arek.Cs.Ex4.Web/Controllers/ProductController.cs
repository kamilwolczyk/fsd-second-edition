using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fsd.Arek.Cs.Ex4.Services.Services;
using Fsd.Arek.Cs.Ex4.Data.Entities;
using Fsd.Arek.Cs.Ex4.Web.Models;

namespace Fsd.Arek.Cs.Ex4.Web.Controllers
{
    public class ProductController : Controller
    {
        private IWarehause _warehause;

        public ProductController()
        {
            _warehause = new Warehause();
        }
       
        public ActionResult List()
        {
            IPaginationPage paginationList = new Pagination();
            IEnumerable<Product> _listproduct;

            if (Request.Params["page"] != null && Request.Params["items"] != null)
               _listproduct = paginationList.CreatePagePositionList(_warehause.GetAllProduct(), int.Parse(Request.Params["page"]), int.Parse(Request.Params["items"]));
            else
                _listproduct = _warehause.GetAllProduct();

            ProductListModel productList = new ProductListModel
            {
                Products = _listproduct.Select(entity => new ProductModel
                {
                    Producer = entity.Producer,
                    Model = entity.Model,
                    Price = entity.Price,
                    Type = entity.Type,
                    DateOfProduction = entity.DateOfProduction
                })
            };
            return View(productList);
        }
    }
}