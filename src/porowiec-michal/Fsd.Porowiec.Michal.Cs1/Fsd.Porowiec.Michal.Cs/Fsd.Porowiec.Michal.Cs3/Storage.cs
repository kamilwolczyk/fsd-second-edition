using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Cs3
{
    class Storage
    {
        string line = "-----------------------------------------------";

        public List<Product> Products = new List<Product>(1);

        public void RunStorage()
        {
            Header(3, "Objects");

            Menu();

            Console.ReadKey();
        }

        void Header(int number, string name)
        {
            Console.WriteLine(line);

            Console.WriteLine($"Exercise {number} - {name}");

            Console.WriteLine(line);
        }

        void Menu()
        {
            Console.WriteLine("What do you want?");

            Option(1, "Buy our product");
            Option(2, "Check our warehouse state");
            Option(3, "Add new product");
            Option(4, "Leave");

            string selectedOption = Console.ReadLine();

            MenuLogic(selectedOption);
        }

        void Option(int optionnumber, string optionname)
        {
            Console.WriteLine($"[{optionnumber}] {optionname}");
        }

        void MenuLogic(string selectedOption)
        {
            switch (selectedOption)
            {
                case "1":
                    BuyProduct();
                    break;
                case "2":
                    GoToStorage();
                    break;
                case "3":
                    AddProduct();
                    break;
                case "4":
                    Leave();
                    break;
                default:
                    try
                    {
                        throw new Exception("You didn't choose correct number of action.");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                        Menu();
                        break;
                    }
            }
        }

        void BuyProduct()
        {
            CheckStorageState();

            Console.WriteLine("Type name of product you want to buy.");

            string productName = Console.ReadLine();

            Console.WriteLine("How many products you want to buy?");

            string productCount = Console.ReadLine();

            int productCountFormated = Int32.Parse(productCount);

            RemoveProductFromStorage(productName, productCountFormated);

            Console.ReadKey();

            ClearAndBack();
        }

        void CheckStorageState()
        {
            Console.Clear();

            Console.WriteLine("PRODUCTS");

            Console.WriteLine(line);

            Console.WriteLine(String.Format("{1,5}|{2,5}|{3,5}|", "", "Name", "Price", "Count"));

            Console.WriteLine(line);

            DisplayProduct();

            Console.WriteLine(line);
        }

        void GoToStorage()
        {
            Console.Clear();

            Console.WriteLine("PRODUCTS");

            Console.WriteLine(line);

            Console.WriteLine(String.Format("{1,5}|{2,5}|{3,5}|", "", "Name", "Price", "Count"));

            Console.WriteLine(line);

            DisplayProduct();

            Console.WriteLine(line);

            Console.WriteLine("Click anykey to comebak.");

            Console.ReadKey();

            BackToMenu();
        }

        void BackToMenu()
        {
            Console.Clear();

            Header(3, "Objects");

            Menu();
        }

        void AddProduct()
        {
            Console.WriteLine("What's the name of product you want to add?");

            string productName = Console.ReadLine();
            string productNameFormat = productName.ToLower();

            for (int i = 0; i < Products.Count; i++)
            {
                if (productNameFormat == Products[i].Name)
                    AddExistingProduct(productName, productNameFormat);
            }

            AddNewProduct(productName);
        }

        void Leave()
        {
            return;
        }

        void AddNewProduct(string productName)
        {
            Console.WriteLine($"How many {productName} you want to add?");

            string numberOfproducts = Console.ReadLine();

            Console.WriteLine($"What should be {productName} price?");

            string price = Console.ReadLine();

            long priceFormated = Int64.Parse(price);

            int toIntnumberOfProducts = Int32.Parse(numberOfproducts);

            Products.Add(new Product(productName, toIntnumberOfProducts, priceFormated));

            ClearAndBack();
        }

        void AddExistingProduct(string productName, string productNameFormated)
        {
            Console.WriteLine($"How many {productName} you want to add?");

            string numberOfproducts = Console.ReadLine();

            int toIntnumberOfProducts = Int32.Parse(numberOfproducts);

            for (int x = 0; x < Products.Count; x++)
            {
                string listProductName = Products[x].Name.ToLower();

                if (productNameFormated == listProductName)
                    Products[x].AddCount(toIntnumberOfProducts);
            }

            ClearAndBack();
        }

        void DisplayProduct()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine(String.Format("{1,5}|{2,5}|{3,5}|", "", Products[i].Name, Products[i].Price, Products[i].Count));
            }
        }

        void RemoveProductFromStorage(string productname, int productcount)
        {
            string productName = productname.ToLower();

            for (int i = 0; i < Products.Count; i++)
            {
                if (productName == Products[i].Name.ToLower())
                {
                    Products[i].RemoveCount(productcount);
                    if (Products[i].Count <= productcount)
                        Console.WriteLine($"That operation did cost you: {productcount * Products[i].Price}");
                }
            }
        }

        void ClearAndBack()
        {
            GoToStorage();

            Console.ReadKey();

            BackToMenu();
        }
    }
}
