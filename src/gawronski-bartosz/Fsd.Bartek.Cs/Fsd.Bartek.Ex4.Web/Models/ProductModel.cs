using Fsd.Bartek.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Bartek.Ex4.Web.Models
{
    public class ProductModel
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public string ProductionData { get; set; }

        public ProductsType Type { get; set; }
    }
}