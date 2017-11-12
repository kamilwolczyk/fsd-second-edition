using Fsd.Artur.Cs3.WareHouse;
using System;

namespace Fsd.Artur.Cs3.ShopActions
{
    class CheckingStateOfWarehouse
    {
        public static void CheckProducts(Warehouse store)
        {
            const string line = "--------------------------------------------------------";

            Console.Clear();
            Console.WriteLine($"PRODUCTS{Environment.NewLine}{line}{Environment.NewLine}|                            NAME  |  PRICE  |  COUNT  |{Environment.NewLine}{line}");

            foreach (var item in store.ShowState())
            {
                Console.WriteLine($"|                      {item.NameOfItem}  |   {item.Price}   |   {item.Count}    |{Environment.NewLine}{line}");
            }

            LeavingShop.Leave(store);
        }
    }
}
