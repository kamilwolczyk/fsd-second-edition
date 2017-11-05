using System.Collections.Generic;
using Weekend3.ConsoleApp.LinqTest;

namespace Weekend3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFarmer farmer = new Farmer();
            //farmer.DoWork();

            //KwList<int> list = new KwList<int>(10);
            //list.Add(2);
            //list.Add(3);

            LinqLearning linq = new LinqLearning();
            linq.Test();

            Test("x");
            Test("x", "y");
            Test("x", "y", 3);
            Test(
                x:"x", 
                z: 2, 
                y:"y");
        }

        static void Test(string x="", string y = "", int z = 1)
        {

        }

        static void ShowAllItems(IEnumerable<int> items)
        {
            foreach (var item in items)
                System.Console.WriteLine(item);
        }


        
    }
}
