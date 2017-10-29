namespace Fsd.Sebastian.Cs2.Animals
{
    public class Sheep : Animal
    {
        public Sheep(string name) : base(name) { }

        public override string SayHello()
        {
            return $"{base.SayHello()}, Bee Bee Bee.";
        }
    }
}
