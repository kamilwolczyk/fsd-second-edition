using Fsd.Bartek.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bartek.Ex4.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public DateTime  ProductionData { get; set; }

        public ProductsType Type { get; set; }
    }
}
