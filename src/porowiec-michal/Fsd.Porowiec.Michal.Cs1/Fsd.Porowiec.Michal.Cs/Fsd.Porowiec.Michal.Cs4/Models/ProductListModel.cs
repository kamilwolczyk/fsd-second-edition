using Fsd.Porowiec.Michal.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Porowiec.Michal.Cs4.Models
{
    public class ProductListModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}