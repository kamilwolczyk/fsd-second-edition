using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs3.Domain.Menu
{
    class ConsoleMenu
    {
        const string line = "-----------------------------";

        public void Run()
        {
            SetHeader(3, "Objects");
            SubMenu subMenu = new SubMenu();
            int option = subMenu.ShowMainMenu();

            switch (option)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    subMenu.ShowWareHauseState();
                    break;
                case 3:
                    Console.WriteLine("case 1");
                    break;
                case 4:
                    return;
                    break;

                default:
                    break;
            }

        }

        public void SetHeader(int numberExcercise, string subject)
        {
            Console.WriteLine($"Exercise {numberExcercise} - {subject} \n{line}");
        }

        public int MainMenu()
        {
            return 0;
        }
    }
}
