using System;
using System.Collections.Generic;
using System.Linq;
using Fsd.Kamil.Cs.Ex3.Models;

namespace Fsd.Kamil.Cs.Ex3.UserInterface
{
    public class Salesman : ISalesman
    {
        private const string Line = "-------------------------------------------";

        private readonly string _name;

        public Salesman(string name)
        {
            _name = name;
        }

        public void WelcomeCustomer()
        {
            Console.WriteLine($"Hello customer, my name is {_name}.");
        }

        public SalesmanAction AskAboutAction()
        {
            Console.Clear();

            while (true)
            {
                Introduction();
                Console.WriteLine();
                Console.WriteLine("What do you want?");
                Console.WriteLine("[1] Buy our product");
                Console.WriteLine("[2] Check our warehouse state");
                Console.WriteLine("[3] Add new product");
                Console.WriteLine("[4] Leave");
                Console.Write("Decision: ");
                var selectedKey = Console.ReadKey();

                switch (selectedKey.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        return SalesmanAction.SellProduct;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        return SalesmanAction.CheckState;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        return SalesmanAction.AddProduct;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        return SalesmanAction.Leave;
                }
                Console.Clear();
                Console.WriteLine("Invalid key. Try again...");
            }
        }

        public void ShowAvailableProducts(IEnumerable<Product> products)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("PRODUCTS");

            if (!products.Any())
            {
                Console.WriteLine("Any products found in the shop.");
                return;
            }
            Console.WriteLine(Line);
            Console.WriteLine("|{0,30}|{1,5}|{2,5}|", "Name", "Price", "Count");
            Console.WriteLine(Line);

            foreach (var product in products)
                Console.WriteLine("|{0,30}|{1,5}|{2,5}|", product.Name, product.Price, product.Count);

            Console.WriteLine(Line);
        }

        public void ShowError(string message)
        {
            Console.WriteLine(message);
        }

        public bool Finish()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to leave shop? [(Y)es] [(N)o]");
            return Console.ReadKey().Key == ConsoleKey.Y;
        }

        public Product ReadProductInformation(bool getPrice, bool getCount)
        {
            var product = new Product();

            Console.Clear();
            Console.WriteLine();
            Console.Write("Name:");

            product.Name = Console.ReadLine();

            if (getPrice)
            {
                Console.Write("Price:");
                product.Price = float.Parse(Console.ReadLine());
            }

            if (getCount)
            {
                Console.Write("Count:");
                product.Count = int.Parse(Console.ReadLine());
            }

            return product;
        }

        private void Introduction()
        {
            Console.WriteLine("Exercise 3 - Objects");
            Console.WriteLine("------------------------------------");
        }
    }
}