using Fsd.Artur.Cs3.ConsoleActions;
using Fsd.Artur.Cs3.WareHouse;

namespace Fsd.Artur.Cs3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse store = new Warehouse();

            ConsoleMessage.Start();

            MainViev.ShowView(ClearView.New, store);

            ConsoleMessage.End();
        }
    }
}
