namespace Fsd.Sebastian.Cs2.Animals
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override string SayHello()
        {
            return $"{base.SayHello()}, Miauuuu.";
        }
    }
}
