using Fsd.Artur.Cs3.WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs3.ShopActions
{
    class CheckStateOfWarehouse
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

            LeaveShop.Leave(store);
        }
    }
}
