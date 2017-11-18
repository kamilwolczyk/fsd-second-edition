using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2_3.ProductMagazine
{
    public class Products
    {
        public string Name { get; set; }

        public string Price { get; set; }

        public string Count { get; set; }

        public Products(string name, string price, string count)
        {
            Name = name;
            Price = price;
            Count = count;
        }


    }
}
