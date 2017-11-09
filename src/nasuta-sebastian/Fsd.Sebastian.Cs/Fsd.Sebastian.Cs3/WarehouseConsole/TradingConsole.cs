using Fsd.Sebastian.Cs3.Content;
using System.Collections.Generic;

namespace Fsd.Sebastian.Cs3.WarehouseConsole
{
    public class TradingConsole
    {
        public static void Buy(List<Product> products)
        {
            string toFind;

            Product foundItem;

            int count;

            do
            {
                toFind = ConsolePresenter.GetString("What do you want to buy (Enter \"QUIT\" for back to main menu): ");

                if (toFind == "QUIT")
                {
                    ConsolePresenter.ClearConsole();
                    return;
                }

                if (products.Exists(item => item.Name.Contains(toFind)) == false)
                {
                    ConsolePresenter.GetChar("No results found, press any key. ");
                    ConsolePresenter.ClearConsole();
                }
            }
            while (products.Exists(item => item.Name.Contains(toFind)) == false);

            foundItem = products.Find(item => item.Name.Contains(toFind));

            count = ConsolePresenter.GetInt("Quantity: ");

            while (foundItem.Count < count)
            {
                count = ConsolePresenter.GetInt($"Sorry, we have only {foundItem.Count}, insert new value or enter \"0\" for back to main menu: ");
                if (count == 0)
                {
                    ConsolePresenter.ClearConsole();
                    return;
                }
            }

            char answer;
            do
            {
                answer = ConsolePresenter.GetChar($"Do you want to buy {count} x {foundItem.Name}? It will cost {count * (foundItem.Price)}. [(Y)es] [(N)o] ");
                ConsolePresenter.ClearConsole();
            }
            while (answer != 'y' && answer != 'n' && answer != 'Y' && answer != 'N');

            if (answer == 'y' || answer == 'Y')
                products.Find(item => item.Name.Contains(toFind)).Count = foundItem.Count - count;
        }
    }
}

