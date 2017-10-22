using System;

namespace Weekend2
{
    public class ConsolePresenter
    {
        string _line = "-----------------------";

        public void Introduction(int exerciseNumber)
        {
            ShowInTwoLines($"  Exercise {exerciseNumber}");
        }

        public void Footer()
        {
            ShowInTwoLines("Kamil Wolczyk");
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
