using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.UI
{
    public abstract class BasicUi
    {
        private static  string line = "------------------------------";
        
        public static void Introducion(int exercise, string name)
        {
            Console.WriteLine(line);
            Console.WriteLine($"Exercise {exercise} - {name}");
            Console.WriteLine(line);
        }

        public static void End()
        {
            Console.ReadKey();
        }
    }
}
