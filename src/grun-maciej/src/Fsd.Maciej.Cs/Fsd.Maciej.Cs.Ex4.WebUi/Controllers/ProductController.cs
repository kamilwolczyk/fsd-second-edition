using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Maciej.Cs.Ex4.WebUi.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        //[Route("products new {page, prod}")]
        public ActionResult Index(string page, string prod )
        {
            ViewBag.Controller = "Product";
            ViewBag.Action = "Index";
            
            ViewBag.variable1 = page;
            ViewBag.variable2 = prod;

            return View("ActionName");
        } 
        public string Testowy(string testy)
        {
            return $"fdsf: {testy}";
        }

       // [Route("products")]
        public ActionResult List()
        {
            ViewBag.Controller = "Product";
            ViewBag.Action = "List";
            ViewBag.Color = RouteData.Values["id"];

            return View("ActionName");
        }
    }
}