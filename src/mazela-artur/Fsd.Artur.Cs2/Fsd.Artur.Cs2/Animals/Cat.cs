namespace Fsd.Artur.Cs2.Animals
{
    public class Cat : Animal, INoise
    {
        public Cat(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{SayHello()}, Miau Miau Miau.";
        }
    }
}
