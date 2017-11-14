using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Arek.Cs.Ex4.Web.Models
{
    public class ProductModel
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string Type { get; set; }

        public DateTime DateOfProduction { get; set; }
    }
}