using System;
using System.Web.Mvc;
using Weekend3.Web.Core;

namespace Weekend3.Web.Controllers
{
    public class DateController : Controller
    {
        private ActionResult GetDateString(DateTime date, string format)
        {
            if (format == null)
                format = "dd.MM.yyyy";

            return View("FormattedDateTime", date.ToString(format) as object);
        }

        public ActionResult Now(string format)
        {
            return GetDateString(DateTime.Now, format);
        }

        public ActionResult Yeasterday(string format)
        {
            return GetDateString(DateTime.Now.AddDays(-1), format);
        }
    }
}