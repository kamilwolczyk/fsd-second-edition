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

        public Producer Producer { get; protected set; }

        public double  Price { get; protected set; }

        public string DateOfProduction { get; protected set; }

        public ProductType Type { get; protected set; }

        public Product (string model, Producer producer, double price, string dateOfProduction, ProductType type)
        {
            Model = model;
            Producer = producer;
            Price = price;
            DateOfProduction = dateOfProduction;
            Type = type;
        }
    }
}
