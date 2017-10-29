using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsd_bielewicz_jacek_HomeWork1
{




    class Program : Tools

    {

        static void Main(string[] args)

        {
            DateTime data = DateTime.Today;
            String dataToPrint = data.ToShortDateString();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Excercise 1 - Inroducktion");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Today is " + dataToPrint);
            Console.WriteLine();

                int countUpper = 0, countLower = 0, countDigit = 0, j;             
                Int32 argumentsLength = args.Length; 
                Int32 r = 0; // the varaiable "r" changes number of index of args Array at each iteration of the  for loop below.

                for (int i = 0; i < argumentsLength; i++)
                {
                    Console.WriteLine("Console Arguments:");

                    if (args.Length > 0)
                    {
                        string sentence = args[r];
                        for (j = 0; j < sentence.Length; j++)
                        {
                            if (char.IsUpper(sentence[j])) countUpper++;
                            if (char.IsLower(sentence[j])) countLower++;
                            if (char.IsDigit(sentence[j])) countDigit++;
                        }

                        Console.WriteLine("Argument " + r + " of " + args.Length);
                        Console.WriteLine("Argument Value: " + args[r]); 
                        Console.WriteLine("Upper letters: " + countUpper);
                        Console.WriteLine("Lower letters: " + countLower);
                        Console.WriteLine("Digits: " + countDigit);
                        Console.WriteLine();
                    }

                    r++;
                    countUpper = 0;
                    countLower = 0;
                    countDigit = 0;
                    Pause();
                }
        }

    }
}

