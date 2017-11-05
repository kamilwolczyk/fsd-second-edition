using Weekend3.ConsoleApp.Animals.Views;
using Weekend3.Services.Providers;
using Weekend3.Services.Services;

namespace Weekend3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            INamesProvider provider = new ConsoleUserInterface();
            IFarmer farmer = new Farmer(provider);
            farmer.DoWork();
        }
    }
}
