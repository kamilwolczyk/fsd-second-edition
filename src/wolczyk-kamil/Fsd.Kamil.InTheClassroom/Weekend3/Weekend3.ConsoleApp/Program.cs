using Weekend3.ConsoleApp.Animals.Models.Services;

namespace Weekend3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFarmer farmer = new Farmer();
            farmer.DoWork();
        }
    }
}
