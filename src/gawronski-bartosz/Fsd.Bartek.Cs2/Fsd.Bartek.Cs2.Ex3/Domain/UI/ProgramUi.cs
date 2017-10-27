using Fsd.Bartek.Cs2.Ex2.Domain.UI;
using Fsd.Bartek.Cs2.Ex3.Domain.Magazine;
using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.UI
{
    public abstract class ProgramUi
    {
        public static void Decision(bool clear, Magazin shop)
        {
            if (clear)
                Console.Clear();

            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.Write("Decision:");
            try
            {
                LogicUi.Check(int.Parse(Console.ReadLine()), shop);
            }
            catch
            {
                Console.WriteLine("Bad decision");
                Decision(true, shop);
            }
        }
        
        public static void AddProducts(Magazin shop)
        {
            Console.Clear();
            try
            {
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Its not price");
                int count = int.Parse(Console.ReadLine());    
                Console.WriteLine("Its not price");
                Console.Write("Count:");

                Console.WriteLine(shop.AddItem(name, price, count));
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }


            Console.Write("Do you want to leave shop? [(Y)es] [(N)o]");
            LogicUi.LeaveShop(Console.ReadLine().ToLower(), shop);
        }

        public static void CheckProducts(Magazin shop)
        {
            string line = "--------------------------------------------------";

            Console.Clear();
            Console.WriteLine("PRODUCTS");
            Console.WriteLine(line);
            Console.WriteLine("|NAME                                 PRICE  COUNT|");
            Console.WriteLine(line);
            foreach (var item in shop.WareReturn())
            {
                Console.WriteLine($"|{item.Name}                              {item.Price}  {item.Count}|");
            }
            Console.WriteLine(line);

            Console.Write("Do you want to leave shop? [(Y)es] [(N)o]");
            LogicUi.LeaveShop(Console.ReadLine().ToLower(), shop);
        }

        public static void BuyProducts(Magazin shop)
        {
            Console.Clear();
            Console.Write("Search Product (Name): ");
            Console.WriteLine(LogicUi.SearchProduct(Console.ReadLine(), shop));

            Console.Write("Do you want to leave shop? [(Y)es] [(N)o]");
            LogicUi.LeaveShop(Console.ReadLine().ToLower(), shop);
        }
    }
}
