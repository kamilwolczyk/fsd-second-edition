using System;

namespace Fsd.Exercise1
{
    public class CheckCharInMyArgs
    {
        private int _digitsCount = 0;
        private int _upperCount = 0;
        private int _lowerCount = 0;

        public void CountCharactersInArguments(string[] argsToCheck)
        {
            for (int i = 0; i < argsToCheck.Length; i++)
            {
                Console.WriteLine($"Argument {i + 1} of {argsToCheck.Length}");
                Console.WriteLine($"Value: {argsToCheck[i]}");
                CountCharactersByType(argsToCheck[i]);
                PrintCounters();
                ResetCounters();
            }
        }

        private void PrintCounters()
        {
            Console.WriteLine($"Upper letters: {_upperCount}");
            Console.WriteLine($"Lower letters: {_lowerCount}");
            Console.WriteLine($"Digits: {_digitsCount}\n");
        }

        private void ResetCounters()
        {
            _digitsCount = 0;
            _upperCount = 0;
            _lowerCount = 0;
        }

        private void CountCharactersByType(string argsToCheck)
        {
            for (int j = 0; j < argsToCheck.Length; j++)
            {
                char charToCheck = argsToCheck[j];

                if (char.IsDigit(charToCheck))
                {
                    _digitsCount++;
                    continue;
                }

                if (char.IsUpper(charToCheck))
                {
                    _upperCount++;
                    continue;
                }

                if (char.IsLower(charToCheck))
                {
                    _lowerCount++;
                    continue;
                }
            }
        }
    }
}