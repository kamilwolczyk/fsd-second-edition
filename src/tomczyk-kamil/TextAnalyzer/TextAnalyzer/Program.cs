using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Exercise 1 - Introduction");
            Console.WriteLine("-------------------------------------  \n");
            Console.WriteLine($"Today is: {DateTime.Now.ToString("dd.MM.yyyy")}");
            Console.WriteLine("\n");

            if (args.Length == 0)
            {
                Console.WriteLine("No arguments. Exit.");
            }
            else
            {
                Console.WriteLine("Console arguments:");

                for (int i = 0; i < args.Length; ++i)
                {
                    Console.WriteLine($"Argsument {i + 1} of {args.Length}");
                    Console.WriteLine($"Value: {args[i]}");
                    Console.WriteLine("Upper letters: " + IfIsUpper(args[i]));
                    Console.WriteLine("Lower letters: " + IfIsLower(args[i]));
                    Console.WriteLine("Digits: " + IfIsDigit(args[i]));
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }

        static int IfIsUpper(string args)
        {
            int iUpperLetters = 0;

            foreach (char c in args)
            {
                if (char.IsUpper(c))
                {
                    iUpperLetters = iUpperLetters + 1;
                }
            }
            return iUpperLetters;
        }
        static int IfIsLower(string args)
        {
            int iLowerLetters = 0;

            foreach (char c in args)
            {
                if (char.IsLower(c))
                {
                    iLowerLetters = iLowerLetters + 1;
                }
            }
            return iLowerLetters;
        }

        static int IfIsDigit(string args)
        {
            int iDigits = 0;

            foreach (char c in args)
            {
                if (char.IsNumber(c))
                {
                    iDigits = iDigits + 1;
                }
            }
            return iDigits;
        }
    }
}



