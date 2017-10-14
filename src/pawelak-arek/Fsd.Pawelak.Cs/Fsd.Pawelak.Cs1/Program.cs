using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Excercise1.Cs
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excersice 1 - Introduction");
            SetUnderLine(30, '-');
            Console.WriteLine($"Today is {DateTime.Now}\n");
            Argument consoleArgument = new Argument();
            consoleArgument.ShowArgumentInfo(args);
            Console.ReadKey();
        }

        static void SetUnderLine(int numOfChar, char character)
        {
            for (int i = 0; i < numOfChar; i++)
                Console.Write(character);

            Console.WriteLine("");
        }
    }
}
