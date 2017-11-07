using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Sebastian.Cs.Ex4.Data.Entities
{
    public class Product
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        public ProductType Type { get; set; }

        public Product(string producer, string model, decimal price, DateTime date, ProductType type)
        {
            Producer = producer;
            Model = model;
            Price = price;
            Date = date;
            Type = type;
        }
    }
}