using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            SetStartText();

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
                    Console.WriteLine("Upper letters: " + GetUpperCount(args[i]));
                    Console.WriteLine("Lower letters: " + GetLowerCount(args[i]));
                    Console.WriteLine("Digits: " + GetDigitCount(args[i]));
                }
            }

            SetEndText();
            Console.ReadKey();
        }

        static int GetUpperCount(string args)
        {
            int iUpperLetters = 0;

            foreach (char c in args)
            {
                if (char.IsUpper(c)) iUpperLetters = iUpperLetters + 1;
            }
            return iUpperLetters;
        }
        static int GetLowerCount(string args)
        {
            int iLowerLetters = 0;

            foreach (char c in args)
            {
                if (char.IsLower(c)) iLowerLetters = iLowerLetters + 1;
            }
            return iLowerLetters;
        }

        static int GetDigitCount(string args)
        {
            int iDigits = 0;

            foreach (char c in args)
            {
                if (char.IsNumber(c)) iDigits = iDigits + 1;                
            }
            return iDigits;
        }

        static void SetStartText()
        {
            Console.WriteLine("\n Exercise 1 - Introduction");
            Console.WriteLine("-------------------------------------  \n");
            Console.WriteLine($"Today is: {DateTime.Now.ToString("dd.MM.yyyy")}");
            Console.WriteLine("\n");
        }

        static void SetEndText()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Click any key to continue...");
        }
    }
}