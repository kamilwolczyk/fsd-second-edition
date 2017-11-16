using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Jacek.Cs3.Tools
{
    public class Warehouse
    {
        private List<ProductSlot> _stack = new List<ProductSlot>();

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Cheackm our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
        }

        static int ReadProducktCount()
        {
            string input = Console.ReadLine();
            int value = 0;
            if (int.TryParse(input, out value))
            {
                return value;
            }
            return 0;
        }

        public bool LeaveShowpPrompt()
        {
            Console.Write("Do you want to levae our shop? [(Y)es] [(N)op]");
            string input = Console.ReadLine();

            bool leave = input == "N" || input == "n";

            return leave;
        }

        public void ShowStack()
        {
            Console.Clear();

            Console.WriteLine("|\tName\t|\tPrice\t|\tCount\t|");

            for (int i = 0; i < _stack.Count; i++)
            {
                Console.WriteLine("|\t" + _stack[i].Product.Name + "\t|\t" + _stack[i].Product.Price + "\t|\t" + _stack[i].Count + "\t|");
            }
        }

        public void BuyProduct()
        {
            Console.Clear();
            Console.WriteLine("Chose product");
            int decision = 0;
            float productPurchasedNumber = 0;
            for (int i = 0; i < _stack.Count; i++)
            {
                Console.WriteLine( "[" + i  + "] "+_stack[i].Product.Name + " unit price is  " + _stack[i].Product.Price + " USD" );
            }
            decision = ReadProducktCount();
            Console.WriteLine("You have chosen " + _stack[decision].Product.Name);
            Console.WriteLine("We have " + _stack[decision].Count + " units avalible, pls choose produckt count");
            productPurchasedNumber = ReadProducktCount();
            float totalPrice = productPurchasedNumber * _stack[decision].Product.Price;
            Console.WriteLine("You have purchased " + productPurchasedNumber + " " + _stack[decision].Product.Name + " for " + totalPrice +  " USD" );
        }

        public void AddProduct()
        {
            Console.Clear();

            ProductSlot slot = new ProductSlot();
            Product product = new Product();
            slot.Product = product;

            string input = string.Empty;
            Console.Write("Name: ");
            input = Console.ReadLine();
            product.Name = input;

            Console.Write("Price: ");
            float price = 0;
            input = Console.ReadLine();
            price = float.Parse(input);
            product.Price = price;

            Console.Write("Count: ");
            input = Console.ReadLine();
            int count = int.Parse(input);
            slot.Count = count;

            _stack.Add(slot);
        }
    }
}
