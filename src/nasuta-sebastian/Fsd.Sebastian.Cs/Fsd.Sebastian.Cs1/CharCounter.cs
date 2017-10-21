using System;

namespace Fsd.Sebastian.Cs1
{
    class CharCounter
    {
        public void Run(string[] args)
        {
            Console.WriteLine("Console arguments:\n");

            if (args.Length == 0)
            {
                Console.WriteLine("No arguments\n");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                    Print(i + 1, args.Length, args[i]);
            }
        }

        private int Count(string arg, CharType type)
        {
            int count = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                if ((type == CharType.Upper && char.IsUpper(arg[i])) || (type == CharType.Lower && char.IsLower(arg[i])) || (type == CharType.Digit && char.IsDigit(arg[i])))
                    count++;
            }
            return count;
        }

        private void Print(int index, int count, string value)
        {
            Console.WriteLine($"Argument {index} of {count}");
            Console.WriteLine($"Value: {value}");
            Console.WriteLine($"Upper letters: {Count(value, CharType.Upper)}");
            Console.WriteLine($"Lower letters: {Count(value, CharType.Lower)}");
            Console.WriteLine($"Digits: {Count(value, CharType.Digit)}\n");
        }
    }
}
