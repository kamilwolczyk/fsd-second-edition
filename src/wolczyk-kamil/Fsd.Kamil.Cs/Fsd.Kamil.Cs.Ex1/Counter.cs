namespace Fsd.Kamil.Cs.Ex1
{
    public class Counter
    {
        private static int Calculate(string value, char start, char end)
        {
            int count = 0;

            for (var i = 0; i < value.Length; i++)
            {
                char item = value[i];

                if (item >= start && item <= end)
                    count++;
            }

            return count;
        }

        public static int CalculateDigitsNumber(string value)
        {
            return Calculate(value, '0', '9');
        }

        public static int CalculateUpperCaseNumber(string value)
        {
            return Calculate(value, 'A', 'Z');
        }

        public static int CalculateLowerCaseNumber(string value)
        {
            return Calculate(value, 'a', 'z');
        }
    }
}
