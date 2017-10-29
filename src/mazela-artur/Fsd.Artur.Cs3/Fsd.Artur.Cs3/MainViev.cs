using Fsd.Artur.Cs3.ShopActions;
using Fsd.Artur.Cs3.WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs3
{
    public class MainViev
    {
        public static void ShopViev(EnumAboutConsole isNew, Warehouse store)
        {
            if(isNew==EnumAboutConsole.Old)
                Console.Clear();

            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.Write("Decision:");

            CheckingDecision.Check(int.Parse(Console.ReadLine()), store);
        }
    }
}
