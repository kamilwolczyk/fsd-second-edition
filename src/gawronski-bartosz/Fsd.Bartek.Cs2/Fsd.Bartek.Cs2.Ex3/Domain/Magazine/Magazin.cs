using Fsd.Bartek.Cs2.Ex3.Domain.Magazine.Products;
using System;
using System.Collections.Generic;

namespace Fsd.Bartek.Cs2.Ex3.Domain.Magazine
{
    public class Magazin
    {
        bool there = false;

        List<Product> Ware = new List<Product>
        {
            new Product("Lenove Tab", 950, 10),
            new Product("Asus Zenfone 5", 499, 5)
        };

        public List<Product> WareReturn()
        {
            return Ware;
        }

        public string BuyItem(string name)
        {
            //zrobić zminane stringów na małe litery

            foreach (Product item in Ware)
            {   
                if(item.Name == name)
                {
                    there = true;

                    if(item.Count == 1)
                    {
                        Ware.Remove(item);
                    }
                    else
                    {
                        item.Count--;
                    }
                }
            }

            if (there)
            {
                there = false;
                return "Thank's for buy!";
            }
            else
            {
                throw new Exception("Item dont exist!");
            }
        }
    }
}
