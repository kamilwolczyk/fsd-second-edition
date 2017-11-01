using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs3.Domain
{
    public class Product
    {
        public int ProductId { get; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Product(string name, decimal price, int productID)
        {
            Name = name;
            Price = price;
            ProductId = productID;
        }
    }
}