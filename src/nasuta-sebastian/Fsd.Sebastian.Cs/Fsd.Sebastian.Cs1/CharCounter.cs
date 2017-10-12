using System;

namespace Fsd.Sebastian.Cs1
{
    class CharCounter
    {
        public void Run(string[] args)
        {
            Console.WriteLine("Console arguments:\n");
            if (args.Length == 0) Console.WriteLine("No arguments\n");
            else for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"Argument {i + 1} of {args.Length}");
                    Console.WriteLine($"Value: {args[i]}");
                    Console.WriteLine($"Upper letters: {Count(args[i], CType.Upper)}");
                    Console.WriteLine($"Lower letters: {Count(args[i], CType.Lower)}");
                    Console.WriteLine($"Digits: {Count(args[i], CType.Digit)}\n");
                }
        }

        private int Count(string arg, CType type)
        {
            int count = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                if ((type == CType.Upper && char.IsUpper(arg[i])) || (type == CType.Lower && char.IsLower(arg[i])) || (type == CType.Digit && char.IsDigit(arg[i]))) count++;
            }
            return count;
        }
    }
}
