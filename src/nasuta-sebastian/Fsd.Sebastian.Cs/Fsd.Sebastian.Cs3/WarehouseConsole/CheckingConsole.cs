using Fsd.Sebastian.Cs3.Content;
using System.Collections.Generic;

namespace Fsd.Sebastian.Cs3.WarehouseConsole
{
    public class CheckingConsole
    {
        public static void Check(List<Product> products)
        {
            int spaceForName = 30;
            int spaceForPrice = 6;
            int spaceForCount = 6;
            int tableWidth = spaceForName + spaceForPrice + spaceForCount + 4;

            ConsolePresenter.PrintString($"PRODUCTS");
            ConsolePresenter.PrintString($"{Line(tableWidth)}");
            ConsolePresenter.PrintString($"|{Indent("Name", spaceForName)}|{Indent("Price", spaceForPrice)}|{Indent("Count", spaceForCount)}|");
            ConsolePresenter.PrintString($"{Line(tableWidth)}");

            foreach (var product in products)
                ConsolePresenter.PrintString($"|{Indent(product.Name, spaceForName)}|{Indent(product.Price, spaceForPrice)}|{Indent(product.Count, spaceForCount)}|");

            ConsolePresenter.PrintString($"{Line(tableWidth)}");
        }

        private static string Indent(string text, int spaceForText)
        {
            int count = text.Length;

            string spaces = "";

            for (int i = 0; i < (spaceForText - count); i++)
                spaces = $"{spaces} ";

            return $"{spaces}{text}";
        }

        private static string Indent(int value, int spaceForText)
        {
            int count = value.ToString().Length;

            string spaces = "";

            for (int i = 0; i < (spaceForText - count); i++)
                spaces = $"{spaces} ";

            return $"{spaces}{value}";
        }

        private static string Line(int length)
        {
            string line = "";

            for (int i = 0; i < length; i++)
                line = $"{line}-";

            return line;
        }
    }
}

