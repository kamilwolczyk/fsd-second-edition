namespace Fsd.Sebastian.Cs2.Animals
{
    public class Sheep : Animal, IAnimalPresenter
    {
        public Sheep(string name)
            :base(name)
        {
        }
        
        public override string SayHello()
        {
            return $"{base.SayHello()}, Bee Bee Bee.";
        }
    }
}
