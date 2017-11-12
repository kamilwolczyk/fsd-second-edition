using Fsd.Artur.Cs4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Artur.Cs4.Models.Products
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public DateTime ProductionDate { get; set; }

        public ProductType Type { get; set; }
    }
}