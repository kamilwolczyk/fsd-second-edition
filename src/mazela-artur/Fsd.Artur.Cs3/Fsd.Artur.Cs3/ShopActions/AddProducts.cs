using Fsd.Artur.Cs3.WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs3.ShopActions
{
    public class AddProducts
    {
        public static void AddOne(Warehouse store)
        {
                Console.Clear();

                Console.Write("Write item name:");
                string name = Console.ReadLine();

                Console.Write("Write price:");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Write count:");
                int count = int.Parse(Console.ReadLine());

                Console.WriteLine(store.AddProduct(name, price, count));

                LeaveShop.Leave(store);
        }
    }
}
