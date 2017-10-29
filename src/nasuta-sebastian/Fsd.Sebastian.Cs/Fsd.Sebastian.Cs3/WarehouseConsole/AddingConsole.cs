using Fsd.Sebastian.Cs3.Content;
using System.Collections.Generic;

namespace Fsd.Sebastian.Cs3.WarehouseConsole
{
    public class AddingConsole
    {
        public static void Add(List<Product> products)
        {
            products.Add(new Product(ConsolePresenter.GetString("Producer: "), ConsolePresenter.GetString("Model: "), ConsolePresenter.GetInt("Price: "), ConsolePresenter.GetInt("Count: ")));

            ConsolePresenter.ClearConsole();
        }
    }
}

