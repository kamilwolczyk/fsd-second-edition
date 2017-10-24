using System;

namespace Fsd.Sebastian.Cs2
{
    public class ConsolePresenter
    {
        string _line = "----------------------------";

        public void Header(int exerciseNumber, string title)
        {
            ShowInTwoLines($"Exercise {exerciseNumber} - {title}");
        }

        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static void PrintString(string message)
        {
            Console.WriteLine(message);
        }
        
        public static void Pause()
        {
            Console.WriteLine("Please press any key...");
            Console.ReadKey();
        }

        private void ShowInTwoLines(string text)
        {
            Console.WriteLine(_line);
            Console.WriteLine(text);
            Console.WriteLine(_line);
        }
    }
}
