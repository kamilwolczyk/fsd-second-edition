using Fsd.Jacek.Cs2.MVC;

namespace Fsd.Jacek.Cs2
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactoryController animalFactoryController = new AnimalFactoryController();
            animalFactoryController.ShowView();
        }
    }
}
