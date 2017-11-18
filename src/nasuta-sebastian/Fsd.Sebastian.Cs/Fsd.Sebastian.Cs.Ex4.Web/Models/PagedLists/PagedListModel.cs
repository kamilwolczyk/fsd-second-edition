using PagedList;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;

namespace Fsd.Sebastian.Cs.Ex4.Web.Models.PagedLists
{
    public class PagedListModel
    {
        public IPagedList<ProductModel> Products { get; set; }
    }
}