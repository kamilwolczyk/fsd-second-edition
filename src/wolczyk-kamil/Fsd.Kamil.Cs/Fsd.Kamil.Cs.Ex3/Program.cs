using Fsd.Kamil.Cs.Ex3.UserInterface;
using System;

namespace Fsd.Kamil.Cs.Ex3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Introduction();
            IShop myShop = new Shop(new Salesman("Marek"), new StandardWarehouse());
            myShop.HandleCustomer();
        }

        private static void Introduction()
        {
            Console.WriteLine("Exercise 3 - Classes");
            Console.WriteLine("------------------------------------");
        }
    }
}