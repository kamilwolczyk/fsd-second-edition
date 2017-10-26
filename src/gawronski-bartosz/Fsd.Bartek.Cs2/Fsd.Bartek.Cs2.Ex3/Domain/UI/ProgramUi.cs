using Fsd.Bartek.Cs2.Ex2.Domain.UI;
using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.UI
{
    public abstract class ProgramUi
    {
        public static void Decision(bool clear)
        {
            if (clear)
                Console.Clear();

            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.Write("Decision:");

            LogicUi.Check(int.Parse(Console.ReadLine()));
        }
        
        public static void AddProducts()
        {
            Console.Clear();
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Price:");
            string price = Console.ReadLine();
            Console.Write("Count:");
            string count = Console.ReadLine();

            Console.Write("Do you want to leave shop? [(Y)es] [(N)o]");
            LogicUi.LeaveShop(Console.ReadLine());
        }

        public static void CheckProducts()
        {
            string line = "--------------------------------------------------";

            Console.Clear();
            Console.WriteLine("PRODUCTS");
            Console.WriteLine(line);
            Console.WriteLine("|                                NAME|PRICE|COUNT|");
            Console.WriteLine(line);
            Console.WriteLine();
            Console.WriteLine(line);

            Console.Write("Do you want to leave shop? [(Y)es] [(N)o]");
            LogicUi.LeaveShop(Console.ReadLine());
        }

        public static void BuyProducts()
        {
            Console.Clear();
            Console.Write("Search Product (Name): ");
            Console.WriteLine(LogicUi.SearchProduct(Console.ReadLine()));
            Console.Write("Do you want buy it? [(Y)es] [(N)o]");
            Console.WriteLine(LogicUi.Buy(Console.ReadLine()));

            Console.Write("Do you want to leave shop? [(Y)es] [(N)o]");
            LogicUi.LeaveShop(Console.ReadLine());
        }
    }
}
