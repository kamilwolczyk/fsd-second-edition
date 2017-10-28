using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bielewicz.Jacek.Cs1.Tools
{
    public class Counting : View
    {
        public void Count(string[] args)
        {
            int countUpper = 0, countLower = 0, countDigit = 0, j, numberOfIndexAtEachIteration = 0, argumentsLength = args.Length;
            string sentence;
            
            void CountDigit()
            {
                if (char.IsDigit(sentence[j]))
                {
                    countDigit++;
                }
            }

            void CountLower()
            {
                if (char.IsLower(sentence[j]))
                {
                    countLower++;
                }
            }

            void CountUpper()
            {
                if (char.IsUpper(sentence[j]))
                {
                    countUpper++;
                }
            }

            void CountingCharacters()
            {
                if (argumentsLength > 0)
                {
                    Console.WriteLine(value: $"\n\nConsole Arguments: " + "\n");
                    sentence = args[numberOfIndexAtEachIteration];
                    for (j = 0; j < sentence.Length; j++)
                    {
                        CountUpper();
                        CountLower();
                        CountDigit();
                    }
                }
            }

            for (int i = 0; i < argumentsLength; i++)
            {
                CountingCharacters();
                Console.WriteLine(value: $"{$"Argument: "}{numberOfIndexAtEachIteration} of {argumentsLength}\nArgument Value: {args[numberOfIndexAtEachIteration]}");
                Console.WriteLine(value: $"{$"Upper letters: "}{countUpper}\nLower letters: {countLower}\nNumbers: {countDigit}\n");
                numberOfIndexAtEachIteration++;
                countUpper = 0;
                countLower = 0;
                countDigit = 0;
                Pause();
            }
        }
    }
}