using System;

namespace Fsd.Artur.Cs3.ConsoleActions
{
    public class ConsoleMessage
    {
        private static string line = "----------------------------------------";

        public static void Start()
        {
            Console.WriteLine($"Exercise 3 - Objects{Environment.NewLine}{line}");
        }

        public static void End()
        {
            Console.ReadKey();
        }
    }
}