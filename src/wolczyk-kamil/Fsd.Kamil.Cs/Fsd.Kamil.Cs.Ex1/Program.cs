using System;

namespace Fsd.Kamil.Cs.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string line = "--------------------------------------";

            Console.WriteLine("Exercise 1 - Introduction");
            Console.WriteLine(line);
            Console.WriteLine($"Today is {DateTime.Now.ToShortDateString()}");
            Console.WriteLine();
            Console.WriteLine("Console arguments:");
            Console.WriteLine();

            if (args.Length == 0)
            {
                Console.WriteLine("Arguments have not been specified.");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                    ShowArgumentInfo(args[i], i, args.Length);
            }

            End();
        }

        static void ShowArgumentInfo(string argument, int index, int totalCount)
        {
            Console.WriteLine($"Argument {index} of {totalCount}");
            Console.WriteLine($"Value: {argument}");
            Console.WriteLine($"Upper letters: { Counter.CalculateUpperCaseNumber(argument) }");
            Console.WriteLine($"Lower letters: { Counter.CalculateLowerCaseNumber(argument) }");
            Console.WriteLine($"Digits: { Counter.CalculateDigitsNumber(argument) }");
            Console.WriteLine();
        }

        static void End()
        {
            Console.WriteLine("Click ant key to continue");
            Console.ReadKey();
        }
    }
}
