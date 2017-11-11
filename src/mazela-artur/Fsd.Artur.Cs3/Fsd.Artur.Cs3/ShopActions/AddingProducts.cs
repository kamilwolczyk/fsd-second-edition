using Fsd.Artur.Cs3.WareHouse;
using System;

namespace Fsd.Artur.Cs3.ShopActions
{
    public class AddingProducts
    {
        public static void AddOne(Warehouse store)
        {
            Console.Clear();

            string name = GetName();

            double price = GetPrice();

            int count = GetCount();

            Console.WriteLine(store.AddProduct(name, price, count));

            LeavingShop.Leave(store);
        }

        private static  string GetName()
        {
            Console.Write("Write item name:");
            string name = Console.ReadLine();

            return name;
        }

        private static double GetPrice()
        {
            Console.Write("Write price:");
            double price = double.Parse(Console.ReadLine());

            return price;
        }

         private static int GetCount()
        {
            Console.Write("Write count:");
            int count = int.Parse(Console.ReadLine());

            return count;
        }
    }
}
