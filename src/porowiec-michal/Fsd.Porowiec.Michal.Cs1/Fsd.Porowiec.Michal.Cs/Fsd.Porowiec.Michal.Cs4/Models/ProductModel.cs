using Fsd.Porowiec.Michal.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Porowiec.Michal.Cs4.Models
{
    public class ProductModel
    {
        public string Model { get; set; }

        public Producer Producer { get; set; }

        public double Price { get; set; }

        public string DateOfProduction { get; set; }

        public ProductType Type { get; set; }
    }
}