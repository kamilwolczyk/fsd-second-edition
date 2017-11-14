namespace Fsd.Jacek.Cs1.Tools
{
    public class Counting
    {
        public static int FindNumberOfDigits(string phraseStr)
        {
            int countDigit = 0;
            if (countDigit < phraseStr.Length)
            {
                for (var i = 0; i < phraseStr.Length; i++)
                {
                    char phraseChar = phraseStr[i];
                    if (char.IsDigit(phraseChar) == true)
                        countDigit++;
                }
            }
            return countDigit++;
        }

        public static int FindNumberOfUpper(string phraseStr)
        {
            int countUpper = 0;
            if (countUpper < phraseStr.Length)
            {
                for (var i = 0; i < phraseStr.Length; i++)
                {
                    char phraseChar = phraseStr[i];
                    if (char.IsUpper(phraseChar) == true)
                        countUpper++;
                }
            }
            return countUpper++;
        }

        public static int FindNumberOfLower(string phraseStr)
        {
            int countLower = 0;
            if (countLower < phraseStr.Length)
            {
                for (var i = 0; i < phraseStr.Length; i++)
                {
                    char phraseChar = phraseStr[i];
                    if (char.IsLower(phraseChar) == true)
                        countLower++;
                }
            }
            return countLower++;
        }
    }
}
