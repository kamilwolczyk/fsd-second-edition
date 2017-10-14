using System.Linq;
using System;

namespace Fsd.Excercise1.Cs
{
    class Argument
    {
        public void ShowArgumentInfo(string[] arg)
        {
            if (arg.Length != 0)
            {
                Console.WriteLine("Console arguments: \n");

                for (int i = 0; i < arg.Length; i++)
                {
                    Console.WriteLine($"Argument {i + 1} of {arg.Length}");
                    Console.WriteLine($"Value: {arg[i]}");
                    Console.WriteLine($"Upper letters: {GetSumUpperLetters(arg[i])}");
                    Console.WriteLine($"Lower letters: {GetSumLowerLetters(arg[i])}");
                    Console.WriteLine($"Digits: {GetSumDigits(arg[i])} \n");
                }
            }
            else
            {
                Console.WriteLine("Number of arguments = 0");
            }
        }

        int AnalizeArgument(string argument, ArgumentType argumentType)
        {
            int sum = 0;

            switch (argumentType)
            {
                case ArgumentType.Digit:
                    for (int i = 0; i < argument.Length; i++)
                    {
                        if (char.IsNumber(argument[i]))
                            sum++;
                    }
                    break;
                case ArgumentType.UpperChar:
                    for (int i = 0; i < argument.Length; i++)
                    {
                        if (char.IsUpper(argument[i]))
                            sum++;
                    }
                    break;
                case ArgumentType.LowerChar:
                    for (int i = 0; i < argument.Length; i++)
                    {
                        if (char.IsLower(argument[i]))
                            sum++;
                    }
                    break;
                default:
                    break;
            }

            return sum;
        }

        int GetSumUpperLetters(string argument)
        {
            return AnalizeArgument(argument, ArgumentType.UpperChar);
        }

        int GetSumLowerLetters(string argument)
        {
            return AnalizeArgument(argument, ArgumentType.LowerChar);
        }

        int GetSumDigits(string argument)
        {
            return AnalizeArgument(argument, ArgumentType.Digit);
        }

    }
}
