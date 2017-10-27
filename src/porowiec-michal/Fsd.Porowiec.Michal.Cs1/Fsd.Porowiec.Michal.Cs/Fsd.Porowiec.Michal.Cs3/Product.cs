using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Cs3
{
    class Product
    {
        public string Name { get; private set; }

        public int Count { get; private set; }

        public long Price { get; private set; }

        public Product(string name, int count, long price)
        {
            Name = name;
            Count = count;
            Price = price;
        }

        public void AddCount(int NumberToAdd)
        {
            Count = Count + NumberToAdd;
        }

        public void RemoveCount(int NumberToRemove)
        {
            if (Count < NumberToRemove)
                 Console.WriteLine($"We don't have that many {Name}");
            else
            Count = Count - NumberToRemove;
        }
    }
}
