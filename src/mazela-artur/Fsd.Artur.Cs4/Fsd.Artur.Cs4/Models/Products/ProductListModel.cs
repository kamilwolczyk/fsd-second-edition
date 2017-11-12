using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Artur.Cs4.Models.Products
{
    public class ProductListModel
    {
        public IEnumerable<ProductModel> Products { get; set; }

        public int Take {get; set;}

        public int Skip { get; set; }
    }
}