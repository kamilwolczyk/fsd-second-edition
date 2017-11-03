using System;

namespace Fsd.Sebastian.Cs3
{
    public class ConsolePresenter
    {
        string _line = "---------------------------------------------";

        public void Header(int exerciseNumber, string title)
        {
            ShowInTwoLines($"Exercise {exerciseNumber} - {title}");
            Console.WriteLine("");
        }

        public static char GetChar(string message)
        {
            Console.Write(message);
            ConsoleKeyInfo userInput = Console.ReadKey();

            return char.Parse(userInput.KeyChar.ToString());
        }

        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int GetInt(string message)
        {
            int value;
            bool result;

            do
            {
                result = int.TryParse(GetString(message), out value);
            }
            while (result == false);

            return value;
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

        public static void ClearConsole()
        {
            Console.Clear();
        }

        private void ShowInTwoLines(string text)
        {
            Console.WriteLine(_line);
            Console.WriteLine(text);
            Console.WriteLine(_line);
        }
    }
}
