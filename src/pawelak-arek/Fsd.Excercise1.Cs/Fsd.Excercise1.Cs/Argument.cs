using System.Linq;
using System;

namespace Fsd.Excercise1.Cs
{
    class Argument
    {

        public void ArgumentInfo(string[] arg)
        {
            foreach(string str in arg)
            {
                Console.WriteLine(GetSumUpperLetters(str));
            }
        }

        int GetSumUpperLetters(string argument)
        {
            int sumUpper=0;
            for(int i =0;i<argument.Length;i++)
            {
                if (char.IsUpper(argument[i]))
                    sumUpper++;
            }
            return sumUpper;
        }

        int GetSumLowerLetters(string argument)
        {
            int sumLower = 0;
            for (int i = 0; i < argument.Length; i++)
            {
                if (char.IsLower(argument[i]))
                    sumLower++;
            }
            return sumLower;
        }

        int GetSumDigits(string argument)
        {
            int sumDigit = 0;
            for (int i = 0; i < argument.Length; i++)
            {
                if (char.IsLower(argument[i]))
                    sumDigit++;
            }
            return sumDigit;
        }

    }
}
