using Fsd.Porowiec.Michal.Cs4.Models;
using Fsd.Porowiec.Michal.Data.Products;
using Fsd.Porowiec.Michal.Services.Warehouse;
using Fsd.Porowiec.Michal.Services.Warehouse.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Porowiec.Michal.Cs4.Controllers
{
    public class ProductsController: Controller
    {
        public ActionResult Display()
        {
            ProductListModel model = new ProductListModel();

            if (Request.QueryString["items"] == null && Request.QueryString["page"] == null)
                model.Products = Warehouseman.GetProducts();
            else
            {
                IEnumerable<Product> _slicedProductList = SliceProductArray.SliceProducts(Request.QueryString["page"], Request.QueryString["items"]);
           
                model.Products = _slicedProductList;
            }

            return View("Products", model);
        }
    }
}