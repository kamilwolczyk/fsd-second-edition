using Fsd.Sebastian.Cs.Ex4.Web.Models.PagedLists;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Products(int? page, int? items)
        {
            ProductListModel list = new ProductListModel();

            int pageNumber = page ?? 1;
            int pageSize = items ?? list.Products.Count();

            PagedListModel pagedList = new PagedListModel
            {
                Products = list.Products.ToPagedList(pageNumber, pageSize)
            };
            
            return View(pagedList);
        }
    }
}