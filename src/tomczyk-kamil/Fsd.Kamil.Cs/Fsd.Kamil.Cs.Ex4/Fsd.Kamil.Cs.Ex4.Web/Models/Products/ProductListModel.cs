using System.Collections.Generic;

namespace Fsd.Kamil.Cs.Ex4.Models.Products
{
    public class ProductListModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
        //public IPagedList<ProductModel> Products { get; set; } //na razie nie udało się
    }
}   