using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Bartek.Ex4.Web.Models
{
    public class ProductListModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}