using Fsd.Bartek.Cs2.Ex3.Domain.Magazine.Products;
using System;
using System.Collections.Generic;

namespace Fsd.Bartek.Cs2.Ex3.Domain.Magazine
{
    public class Warehouse
    {
        public List<Product> Wares = new List<Product>
        {
            new Product("Lenovo Tab", 950, 10),
            new Product("Asus Zenfone 5", 499, 5)
        };

        public Product FindWare(string name)
        {
            foreach (Product item in Wares)
            {
                string itemName = item.Name.ToLower();

                if (itemName == name)
                {
                    return item;
                }
            }

            return null;
        }

        public string BuyItem(string name)
        {
            Product item = FindWare(name);

            if(item != null)
            {
                if (item.Count == 1)
                {
                    Wares.Remove(item);
                }
                else
                {
                    item.Count--;
                }

                return "Thank's for buy!";
            }
            else
            {
                return "Item dont exist!";
            }
        }

        public string AddItem(string name, double price, int count)
        {
            Wares.Add(new Product(name, price, count));

            return "Product add";
        }
    }
}
