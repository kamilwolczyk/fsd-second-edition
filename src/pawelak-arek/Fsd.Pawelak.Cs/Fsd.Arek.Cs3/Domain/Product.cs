using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs3.Domain
{
    public class Product
    {
        public string Name { get; }

        public decimal Price { get;}

        public Product (string name , decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}