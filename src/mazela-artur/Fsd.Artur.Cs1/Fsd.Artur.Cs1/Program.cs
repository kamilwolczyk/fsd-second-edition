using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs1
{
    class Program
    {
        static void Main(string[] args)
        {
            WritingMessage();
            CheckingArguments(args);
            Console.WriteLine($"{Environment.NewLine}Click any key to continue...");
            Console.ReadKey();
        }
        static void WritingMessage()
        {
            string marks = "---------------------------------------------";
            Console.WriteLine($"Exercise 1 - Introduction {Environment.NewLine}{marks}{Environment.NewLine}Today is {DateTime.Now.ToShortDateString()}{Environment.NewLine}{Environment.NewLine}Console arguments:{Environment.NewLine}");
 
        }
        static void CheckingArguments(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Program have 0 arguments.");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                    InformationMessage(args[i], i, args.Length);
            }
        }
        static void InformationMessage(string argument_value, int argument_index, int arguments_count)
        {
            {
                Console.WriteLine($"Argument {argument_index} of {arguments_count}{Environment.NewLine}Value: {argument_value}");
                Console.WriteLine($"Upper letters: { AnalysisSymbols.UpperCounter(argument_value)}{Environment.NewLine}Lower letters: {AnalysisSymbols.LowerCounter(argument_value)}{Environment.NewLine}Digits: { AnalysisSymbols.DigitCounter(argument_value)}");  
            }
        }
    }

}
