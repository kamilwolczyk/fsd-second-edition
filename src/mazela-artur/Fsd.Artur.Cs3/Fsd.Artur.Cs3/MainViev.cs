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

            Console.WriteLine($"What do you want?{Environment.NewLine}[1] Buy our product{Environment.NewLine}[2] Check our warehouse state{Environment.NewLine}[3] Add new product{Environment.NewLine}[4] Leave{Environment.NewLine}Decision:");

            CheckingDecision.Check(int.Parse(Console.ReadLine()), store);
        }
    }
}
