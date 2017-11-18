using Fsd.Janus.Damian.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Janus.Damian.Data.Entities
{
    public class Product
    {
        public string Producer { get; protected set; }

        public string Model { get; protected set; }

        public double Price { get; protected set; }

        public string ProductionDate { get; protected set; }

        public ProductType Type { get; protected set; }

        public Product (string producer, string model, double price, string productionDate, ProductType type)
        {
            Producer = producer;
            Model = model;
            Price = price;
            ProductionDate = productionDate;
            Type = type;
        }
    }
}
