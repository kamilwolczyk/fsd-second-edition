using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Gawronski.Bartek.Cs.Ex0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Today is: {DateTime.Now} \n");

            for (int i = 0; i<args.Length; i++)
            {
                Console.WriteLine($"Argument {i} of {args.Length}");
                Console.WriteLine($"Value: {args[i]}");
                Console.WriteLine($"Upper letters: {UppercaseDetect(args[i])}");
                Console.WriteLine($"Lower letters: {LowercaseDetect(args[i])}");
                Console.WriteLine($"Digits: {DigitDetect(args[i])} \n");
            }

            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }
        
        static int UppercaseDetect(string args)
        {
            int sum = 0;

            for(int i = 0; i<args.Length; i++)
            {
                int letter = (int)args[i];
                if (letter >= 65 && letter <= 90)
                    sum++;
            }

            return sum;
        }

        static int LowercaseDetect(string args)
        {
            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                int letter = (int)args[i];
                if (letter >= 97 && letter <= 122)
                    sum++;
            }

            return sum;
        }

        static int DigitDetect(string args)
        {
            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                int letter = (int)args[i];
                if (letter >= 48 && letter <= 57)
                    sum++;
            }

            return sum;
        }
    }
}
