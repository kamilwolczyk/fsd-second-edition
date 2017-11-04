using Fsd.Sebastian.Cs3.Content;
using System;
using System.Collections.Generic;

namespace Fsd.Sebastian.Cs3.WarehouseConsole
{
    public class MainConsole
    {
        public List<Product> Products { get; set; }

        public MainConsole(List<Product> products)
        {
            Products = products;
            MainMenu();
        }

        private void MainMenu()
        {
            char item;

            do
            {
                item = ConsolePresenter.GetChar("What do you want?\n[1] Buy our product\n[2] Check our warehouse state\n[3] Add new product\n[4] Leave\nDecision: ");
                ConsolePresenter.ClearConsole();
            }
            while (item != '1' && item != '2' && item != '3' && item != '4');

            switch (item)
            {
                case '1':
                    TradingConsole.Buy(Products);
                    MainMenu();
                    break;
                case '2':
                    CheckingConsole.Check(Products);
                    Leave();
                    break;
                case '3':
                    AddingConsole.Add(Products);
                    MainMenu();
                    break;
                case '4':
                    Leave();
                    break;
            }
        }

        private void Leave()
        {
            char answer;

            do
            {
                answer = ConsolePresenter.GetChar("\nDo you want to leave shop? [(Y)es] [(N)o] ");
                ConsolePresenter.ClearConsole();
            }
            while (answer != 'y' && answer != 'n' && answer != 'Y' && answer != 'N');

            if (answer == 'y' || answer == 'Y')
                return;
            else
                MainMenu();
        }
    }
}

