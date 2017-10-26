using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs3.Domain
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; }

        public decimal Price { get;}

        public Product (string name , decimal price, int productId)
        {
            Name = name;
            Price = price;
            ProductId = productId;
        }
    }
}