using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex3.ProductMagazine
{
    public class Menu : Text
    {
        public char LeaveOrNot;
        public char ProductDecision;
        public string NameNew;
        public string PriceNew;
        public string CountNew;

        public static void StartMenu()
        {
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.Write("Decision: ");
        }

        public void EndMenuWarehouse()
        {
            Console.WriteLine(Line);
            Console.WriteLine("\n");
            Console.WriteLine("Do you want to leave shop? [(Y)es] [(N)o]");
            Console.WriteLine("\n");
        }

        public void EndMenuBuy()
        {
            Console.WriteLine(Line);
            Console.WriteLine("\n");
            Console.WriteLine("Which number do you chose? [(L)eave]");
            Console.WriteLine("\n");
        }

        public void ProductBuyDecision()
        {
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.Write("Decision: ");
        }

        public void ProductsDecision()
        {
            Console.ReadLine();
            do
            {
                ProductDecision = (char)Console.Read();
            } while (ProductDecision == '\n' | ProductDecision == '\r');

            switch (ProductDecision)
            {
                case '1': BoughtProducts("1"); break;

                case '2': BoughtProducts("2"); break;

                case '3': BoughtProducts("3"); break;

                case 'l': Console.Clear(); Menu.StartMenu(); break;

                default: Console.Clear(); break;
            }
        }

        public void NewProduct()
        {
            Console.ReadLine();
            ProductDetails("NAME");
            NameNew = Console.ReadLine();

            ProductDetails("PRICE");
            PriceNew = Console.ReadLine();

            ProductDetails("COUNT");
            CountNew = Console.ReadLine();

            Products[] items = new Products[]
            {
                new Products("Dell", "2500", "15"),
                new Products("Lenovo", "2700", "122"),
                new Products("Toshiba", "2200", "3"),
            };

            List<Products> list = new List<Products>();

            list.Add(new Products(NameNew, PriceNew, CountNew));

            Console.Clear();
            WriteMenuText();

            foreach (var thing in items)
                Console.WriteLine($"|           {thing.Name}|        {thing.Price}|         {thing.Count}|");

            foreach (var thing in list)
                Console.WriteLine($"|           {thing.Name}|        {thing.Price}|         {thing.Count}|");
        }

        public void ProductsDetails()
        {
            Console.Clear();

            Products[] items = new Products[]
            {
                new Products("Dell", "2500", "15"),
                new Products("Lenovo", "2700", "122"),
                new Products("Toshiba", "2200", "3"),
            };

            List<Products> list = new List<Products>();

            Text textWrite = new Menu();
            textWrite.WriteMenuText();

            foreach (var thing in items)
                Console.WriteLine($"|           {thing.Name}|        {thing.Price}|         {thing.Count}|");

            foreach (var thing in list)
                Console.WriteLine($"|           {thing.Name}|        {thing.Price}|         {thing.Count}|");
        }

        public void LeaveOrNotDecision()
        {
            do
            {
                LeaveOrNot = (char)Console.Read();
            } while (LeaveOrNot == '\n' | LeaveOrNot == '\r');

            switch (LeaveOrNot)
            {
                case 'y': Environment.Exit(0); break;

                case 'n': Console.Clear(); Menu.StartMenu(); break;

                default: Console.Clear(); break;
            }
        }

        public override void WriteMenuText()
        {
            base.WriteMenuText();
            Console.WriteLine("PRODUCTS");
            Console.WriteLine(Line);
            Console.WriteLine("|            Name|        Price|       Count|");
            Console.WriteLine(Line);
        }
    }
}
