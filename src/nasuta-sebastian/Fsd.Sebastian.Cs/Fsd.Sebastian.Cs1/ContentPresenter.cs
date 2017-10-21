using System;

namespace Fsd.Sebastian.Cs1
{
    class ContentPresenter
    {
        public void Header()
        {
            Console.WriteLine($"\nExercise 1 - Introduction\n---------------------------------------------\nToday is {DateTime.Today.ToString("D")}\n");
        }

        public void Footer()
        {
            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }
    }
}