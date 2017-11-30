using Fsd.Kamil.Cs.Ex5.Domain.Api.Enums;
using System;

namespace Fsd.Kamil.Cs.Ex5.Domain.Api.Entities
{
    public class Product
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public string Price { get; set; }

        public DateTime ProductionDate { get; set; }

        public ProductTypes Type { get; set; }
    }
}
