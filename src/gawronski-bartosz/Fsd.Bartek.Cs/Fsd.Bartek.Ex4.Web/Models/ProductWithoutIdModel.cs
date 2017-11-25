using Fsd.Bartek.Ex4.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Bartek.Ex4.Web.Models
{
    public class ProductWithoutIdModel
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public DateTime ProductionData { get; set; }

        public ProductsType Type { get; set; }
    }
}