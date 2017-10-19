using System;

namespace Fsd.Exercise1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintHeader();

            if (args.Length > 0)
            {
                CheckCharInMyArgs checkArgs = new CheckCharInMyArgs();
                checkArgs.CountCharactersInArguments(args);
                PrintFooter();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nYou have not entered any arguments!\n");
                PrintFooter();
            }
        }

        private static void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("\nExercise 1 - Introduction\n");
            string line = "-";

            for (int i = 0; i < 50; i++)
                Console.Write(line);

            Console.WriteLine($"\n\nToday is {DateTime.Now.ToString()}\n");
            Console.WriteLine("Console arguments:\n");
        }

        private static void PrintFooter()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}