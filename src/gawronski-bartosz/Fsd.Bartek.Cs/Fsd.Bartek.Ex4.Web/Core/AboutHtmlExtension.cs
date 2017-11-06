using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Bartek.Ex4.Web.Core
{
    public static class AboutHtmlExtension
    {
        public static MvcHtmlString AboutAuthor(this HtmlHelper helper, string name)
        {
            return new MvcHtmlString($"<br/><br/><br/><br/><br/><div>" +
                $"<p class=\"text-center\">" +
                $"Nazywam się {name} i jestem programista" +
                $"</p>" +
                $"<div>");
        }
    }
}