using Fsd.Artur.Cs3.WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs3.ShopActions
{
    public class LeaveShop
    {
        public static void Leave( Warehouse store)
        {
            Console.WriteLine("Do you want to leave a shop?. Write [Y] or [N]");
            string MadeDecision = Console.ReadLine().ToUpper();
            switch (MadeDecision)
            {
                case "Y":
                    Console.Clear();
                    Console.WriteLine("Thank you for your visit.");
                    break;
                case "N":
                    MainViev.ShopViev(EnumAboutConsole.Old, store);
                    break;
                default:
                    break;
            }
        }
    }
}
