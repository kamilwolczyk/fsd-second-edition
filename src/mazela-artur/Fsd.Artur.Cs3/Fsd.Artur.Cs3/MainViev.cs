using Fsd.Artur.Cs3.ShopActions;
using Fsd.Artur.Cs3.WareHouse;
using System;

namespace Fsd.Artur.Cs3
{
    public class MainViev
    {
        public static void ShowView(ClearView isNew, Warehouse store)
        {
            if(isNew==ClearView.Old)
                Console.Clear();

            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.WriteLine("[4] Leave");
            Console.WriteLine("Decision:");

            CheckingDecision.Check(int.Parse(Console.ReadLine()), store);
        }
    }
}
