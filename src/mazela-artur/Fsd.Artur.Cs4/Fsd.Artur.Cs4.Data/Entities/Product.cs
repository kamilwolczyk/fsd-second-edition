using Fsd.Artur.Cs4.Data.Enums;
using System;

namespace Fsd.Artur.Cs4.Data.Entities
{
    public  class Product
    {
        public int Id { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public DateTime ProductionDate { get; set; }

        public ProductType Type { get; set; }

        public Product(int id, string producer, string model, decimal price, DateTime productionDate, ProductType type)
        {
            Id = id;
            Producer = producer;
            Model = model;
            Price = price;
            ProductionDate = productionDate;
            Type = type;
        }
    }
}
