using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2_3.ProductMagazine
{
    public class TextWriter 
    {
        
        public string Line = "----------------------------------------------";
        public string ExNumber;

        public void ChooseExNumber()
        {
            Console.WriteLine("Wybierz numer zadania domowego: [2] / [3]");
            ExNumber = Console.ReadLine();
        }

        public void InsertTex(string type)
        {
            Console.WriteLine($"Insert number of {type}: ");
        }

        public void StartTextProducts(string exNumber)
        {
            WriteText($"Exercise {exNumber} - Objects ", true);
        }

        public void StartTextAnimals(string exNumber)
        {
            WriteText($"Exercise {exNumber} - Interfaces ", true);
        }

        public void EndText()
        {
            WriteText("Click any key to continue...", true);
        }

        public virtual void WriteText(string text, bool line)
        {
            Console.Title = "PRODUCTS";
            Console.WriteLine(text);
            if (line == true) Console.WriteLine(Line);
            Console.WriteLine("\n");
        }

        public virtual void WriteMenuText()
        {
            Console.Title = "PRODUCTS";
            Console.WriteLine(Line);
        }
    }
}
