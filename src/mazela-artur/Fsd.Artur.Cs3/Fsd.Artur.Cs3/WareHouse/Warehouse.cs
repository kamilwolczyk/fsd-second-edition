using Fsd.Artur.Cs3.WareHouse.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs3.WareHouse
{
    public class Warehouse
    {

        List<Product> Shop = new List<Product>
        {
            new Product("Lenovo Tab", 950, 10),
            new Product("Asus Zenfone 5", 499, 5)
        };

        public List<Product> ShowState()
        {
            return Shop;
        }

        EnumAboutBuy AreBought = EnumAboutBuy.NotBought;

        public string BuyItem(string name)
        {
            name=name.ToUpper();

            foreach (Product item in Shop)
            {
                string itemName = item.NameOfItem.ToUpper();

                if (itemName == name)
                {
                    AreBought = EnumAboutBuy.Bought;

                    if (item.Count == 1)
                        Shop.Remove(item);
                    else
                        item.Count--;
                }
            }

            if (AreBought==EnumAboutBuy.Bought)
            {
                AreBought = EnumAboutBuy.NotBought;
                return "Thank you for bought item.)";
            }
            else
            {
                return "We don't  have item what you ask for.";
            }
        }

        public string AddProduct(string name, double price, int count)
        {
            Shop.Add(new Product(name, price, count));

            return "Product added to the Warehouse. Thank you.";
        }

    }
}
