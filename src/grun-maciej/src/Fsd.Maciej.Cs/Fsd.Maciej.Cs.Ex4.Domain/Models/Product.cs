using System;
using System.Collections.Generic;
using System.Text;

namespace Fsd.Maciej.Cs.Ex4.Domain.Models
{
    class Product
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Type { get; set; }
    }
}
