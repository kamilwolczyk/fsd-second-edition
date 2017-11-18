using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex3.ProductMagazine
{
    public class Text
    {
        public string Line = "----------------------------------------------";

        public void StartText(int exNumber)
        {
            WriteText($"Exercise {exNumber} - Objects ", true);
        }

        public void EndText()
        {
            WriteText("Click any key to continue...", true);
        }

        public void BoughtProducts(string product)
        {
            Console.WriteLine($"You have bought: Product {product} ");
        }

        public void ProductDetails(string detail)
        {
            Console.WriteLine($"Please enter your product '{detail}':");
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
