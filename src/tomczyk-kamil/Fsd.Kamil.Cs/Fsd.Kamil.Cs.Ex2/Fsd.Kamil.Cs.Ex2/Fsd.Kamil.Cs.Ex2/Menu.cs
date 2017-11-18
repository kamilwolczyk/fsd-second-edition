using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Kamil.Cs.Ex2.Animals;

namespace Fsd.Kamil.Cs.Ex2
{
    public class Menu
    {
        public string Line = "----------------------------------------------";

        public void StartText(int exNumber)
        {
            Console.WriteLine($"Exercise {exNumber} - Interfaces ");
            Console.WriteLine("\n");
        }

        public void EndText()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Click any key to continue...");
        }

    }
}
