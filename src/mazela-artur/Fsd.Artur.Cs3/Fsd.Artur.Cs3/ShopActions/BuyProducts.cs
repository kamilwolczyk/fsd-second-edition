using Fsd.Artur.Cs3.WareHouse;
using Fsd.Artur.Cs3.ShopActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs3.ShopActions
{
    public class BuyProducts
    {
        public static void BuyOne(Warehouse store)
        {
            Console.Clear();
            Console.Write("Write name of product:");
            Console.WriteLine(SearchProductInStore(Console.ReadLine(), store));

            LeaveShop.Leave(store);
        }

        private static string SearchProductInStore(string item, Warehouse store)
        {
            return store.BuyItem(item);
        }
    }
}
