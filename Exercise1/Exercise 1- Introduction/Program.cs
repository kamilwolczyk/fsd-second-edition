using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1__Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Exercise 1 - Introduction");
            Console.WriteLine("-------------------------------------  \n");
            Console.WriteLine($"Today is: {DateTime.Now.ToString("dd.MM.yyyy")}");
            Console.WriteLine("\n");



            string sentence = Console.ReadLine();
            int countUpper = 0, countLower = 0, countOther = 0, i;



            for (i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i])) countUpper++;
                else if (char.IsLower(sentence[i])) countLower++;
                else countOther++;

            }
            
            Console.WriteLine("Upper letters: " + countUpper);
            Console.WriteLine("Lower letters: " + countLower);
            Console.WriteLine("Digits: " + countOther);
            Console.WriteLine("\n");
            Console.WriteLine("Click any key to continue...");
            Console.ReadLine();
        }

    }
}