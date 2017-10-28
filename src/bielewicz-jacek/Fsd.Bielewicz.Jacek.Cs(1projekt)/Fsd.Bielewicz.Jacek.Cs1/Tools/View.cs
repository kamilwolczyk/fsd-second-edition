using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bielewicz.Jacek.Cs1.Tools
{
    public class View
    {
        public void Begining()
        {
            Console.WriteLine($"\nExcercise 1 - Inroducktion\n----------------------------------------------\n");
            Console.WriteLine(DateTime.Today.ToString("D"));

        }
        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

