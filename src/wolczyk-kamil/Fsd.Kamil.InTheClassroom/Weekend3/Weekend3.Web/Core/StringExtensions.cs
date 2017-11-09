namespace Weekend3.Web.Core
{
    public static class StringExtensions
    {
        public static int CalculateCharackters(this string value, char character)
        {
            int count = 0;

            foreach (char c in value)
            {
                if (c == character)
                    count++;
            }

            return count;
        }
    }
}