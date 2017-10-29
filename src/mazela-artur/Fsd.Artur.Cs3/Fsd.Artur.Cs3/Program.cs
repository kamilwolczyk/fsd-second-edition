using Fsd.Artur.Cs3.ConsoleActions;
using Fsd.Artur.Cs3.WareHouse;
using Fsd.Artur.Cs3.ShopActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse store = new Warehouse();

            ConsoleMessage.Start();

            MainViev.ShopViev(EnumAboutConsole.New, store);

            ConsoleMessage.Ending();
        }
    }
}
