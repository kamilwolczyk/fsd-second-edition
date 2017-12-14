using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Data.Products
{
    public class Product
    {
        public string Model { get; protected set; }

        public string Producer { get; protected set; }

        public double  Price { get; protected set; }

        public DateTime DateOfProduction { get; protected set; }

        public ProductType Type { get; protected set; }

        public int Id { get; protected set; }

        public Product (string model, string producer, double price, DateTime dateOfProduction, ProductType type, int id)
        {
            Model = model;
            Producer = producer;
            Price = price;
            DateOfProduction = dateOfProduction;
            Type = type;
            Id = id;
        }
    }
}
