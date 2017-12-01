using System;
using Fsd.Jacek.Cs.Ex1.Tools;

namespace Fsd.Jacek.Cs.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            View.Begining();
            if (args.Length == 0)
            {
                Console.WriteLine("no arguments");
            }
            else
            {
                Console.WriteLine("Console arguments:");
                for (int i = 0; i < args.Length; i++)
                {
                    int numer = i + 1;
                    View.ShowingNumberofCharacters(args[i], numer, args.Length);
                    View.Pause();
                }
            }

        }
    }
}
