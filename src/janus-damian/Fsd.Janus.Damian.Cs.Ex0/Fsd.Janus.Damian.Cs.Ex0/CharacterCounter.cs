using System;

namespace Fsd.Janus.Damian.Cs.Ex0
{
    class CharacterCounter
    {
        public void RunCounter(string[] args)
        {
            Console.WriteLine("Console arguments:\n");

            if (args.Length == 0)
            {
                Console.WriteLine("No arguments provide to program.\n");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    CounterMechanic(args[i], i + 1, args.Length);
                }
            }
        }

        private void CounterMechanic(string argument, int index, int numberOfArguments)
        {
            Console.WriteLine($"Argument {index} of {numberOfArguments}");
            Console.WriteLine($"Value: {argument}");
            Console.WriteLine($"Upper letters: { CharacterCounter.CountUpperCharacter(argument) }");
            Console.WriteLine($"Lower letters: { CharacterCounter.CountLowerCharacter(argument) }");
            Console.WriteLine($"Digits: { CharacterCounter.CountDigit(argument) }\n");
        }

        private static int CountUpperCharacter(string argument)
        {
            int numberUpperCharacters = 0;
            for (int i = 0; i < argument.Length; i++)
            {
                if (Char.IsLetter(argument[i]) && (argument[i] == Char.ToUpper(argument[i])))
                {
                    numberUpperCharacters += 1;
                }
            }
            return numberUpperCharacters;
        }

        private static int CountLowerCharacter(string argument)
        {
            int numberLowerCharacters = 0;
            for (int i = 0; i < argument.Length; i++)
            {
                char letter = argument[i];
                if (Char.IsLetter(argument[i]) && (argument[i] == Char.ToLower(argument[i])))
                {
                    numberLowerCharacters += 1;
                }
            }
            return numberLowerCharacters;
        }

        private static int CountDigit(string argument)
        {
            int numberOfDigits = 0;
            for (int i = 0; i < argument.Length; i++)
            {
                if (char.IsDigit(argument[i]))
                {
                    numberOfDigits += 1;
                }
            }
            return numberOfDigits;
        }
    }
}
