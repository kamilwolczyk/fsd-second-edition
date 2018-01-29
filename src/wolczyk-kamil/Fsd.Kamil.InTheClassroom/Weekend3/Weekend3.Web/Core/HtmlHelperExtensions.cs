using System.Web.Mvc;

namespace Weekend3.Web.Core
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString Author(this HtmlHelper helper, string name)
        {
            return new MvcHtmlString($"<div>{name}</div>");
        }
    }
}