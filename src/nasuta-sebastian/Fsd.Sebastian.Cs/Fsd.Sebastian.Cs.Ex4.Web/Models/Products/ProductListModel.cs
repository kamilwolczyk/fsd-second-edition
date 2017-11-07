using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Services.Products;
using System.Collections.Generic;

namespace Fsd.Sebastian.Cs.Ex4.Web.Models.Products
{
    public class ProductListModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}