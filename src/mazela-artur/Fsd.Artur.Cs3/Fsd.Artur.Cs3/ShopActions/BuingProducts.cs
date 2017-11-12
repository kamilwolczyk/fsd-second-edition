using Fsd.Artur.Cs3.WareHouse;
using System;

namespace Fsd.Artur.Cs3.ShopActions
{
    public class BuingProducts
    {
        public static void BuyOne(Warehouse store)
        {
            Console.Clear();
            Console.Write("Write name of product:");
            Console.WriteLine(SearchProductInStore(Console.ReadLine(), store));

            LeavingShop.Leave(store);
        }

        private static string SearchProductInStore(string item, Warehouse store)
        {
            return store.BuyItem(item);
        }
    }
}
