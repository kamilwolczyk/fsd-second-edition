using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Jacek.Cs.Ex1.Tools
{
    class View
    {
        public static void ShowingNumberofCharacters(string argumentValue, int argument_index, int argument_count)
        {
            Console.WriteLine($"Argument: {argument_index} of {argument_count}\nArgument Value: {argumentValue}\n");
            Console.WriteLine($"Number of Digit is   {Counting.FindNumberOfDigits(argumentValue)}");
            Console.WriteLine($"\nNumber of Lower is {Counting.FindNumberOfLower(argumentValue)}");
            Console.WriteLine($"\nNumber of Upper is {Counting.FindNumberOfUpper(argumentValue)}\n");
        }

        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey(true);
        }

        public static void Begining()
        {
            Console.WriteLine($"\nExcercise 1 - Inroducktion\n-----------------------------------------------\n");
            Console.WriteLine(DateTime.Today.ToString("D"));
            Console.WriteLine("");
        }
    }
}
