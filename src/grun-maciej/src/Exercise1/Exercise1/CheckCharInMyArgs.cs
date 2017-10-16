using System;

namespace homework.week1
{
    public class CheckCharInMyArgs
    {
        private int _digitsCount = 0, _upperCount = 0, _lowerCount = 0;

        public void Check(string[] ArgsToCheck)
        {
            int argsCount = ArgsToCheck.Length;
            for (int i = 0; i < argsCount; i++)
            {
                Console.WriteLine($"Argument {i + 1} of {argsCount }");
                Console.WriteLine($"Value: {ArgsToCheck[i]}");
                CountCharactersByType(ArgsToCheck[i]);
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

        private void CountCharactersByType(string ArgsToCheck)
        {
            for (int j = 0; j < ArgsToCheck.Length; j++)
            {
                char charToCheck = ArgsToCheck[j];
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

        private int CheckMyChar(char myChartoCheck)
        {
            if (char.IsDigit(myChartoCheck))
                return 1;

            return 0;
        }
    }
}