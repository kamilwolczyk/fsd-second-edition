using Fsd.Artur.Cs3.WareHouse;
using System;

namespace Fsd.Artur.Cs3.ShopActions
{
    public class LeavingShop
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
                    MainViev.ShowView(ClearView.Old, store);
                    break;
                default:
                    break;
            }
        }
    }
}
