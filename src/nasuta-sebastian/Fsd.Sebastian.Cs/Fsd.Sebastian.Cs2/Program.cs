namespace Fsd.Sebastian.Cs2
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsolePresenter().Header(2, "Interfaces");
            new AnimalFactory().Start();

            ConsolePresenter.Pause();
        }
    }
}
