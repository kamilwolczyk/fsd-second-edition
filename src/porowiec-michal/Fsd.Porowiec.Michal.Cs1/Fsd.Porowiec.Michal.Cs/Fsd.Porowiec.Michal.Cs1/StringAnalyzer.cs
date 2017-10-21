using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Cs1
{
    class StringAnalyzer
    {
        public void Run(string[] args)
        {
            Console.WriteLine($"Today is: {DateTime.Now} \n");
            Console.WriteLine("Console Arguments: \n");

            for (int i = 0; i<args.Length; i++)
            {
                Console.WriteLine($"This is argument number {i+1} of {args.Length}");
                Console.WriteLine($"Argument Value: {args[i]}");
                Console.WriteLine($"Upper Letters: {Uppers(args[i])}");
                Console.WriteLine($"Lower Letters: {Lowers(args[i])}");
                Console.WriteLine($"Digits: {Digits(args[i])} \n");
            }
         
            Console.ReadKey();
        }

        private int Uppers(string sentence)
        {
            int numberOfUppers = 0;

            for(int i =0; i<sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]))
                    numberOfUppers++;
            }
            return numberOfUppers;
        }

        private int Lowers(string sentence)
        {
            int numberOfLowers = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsLower(sentence[i]))
                    numberOfLowers ++;
            }

            return numberOfLowers;
        }

        private int Digits(string sentence)
        {
            int numberOfDigits = 0;

            for (int i=0; i<sentence.Length; i++)
            {
                if (char.IsDigit(sentence[i]))
                    numberOfDigits++;
            }

            return numberOfDigits;
        }
    }
}
