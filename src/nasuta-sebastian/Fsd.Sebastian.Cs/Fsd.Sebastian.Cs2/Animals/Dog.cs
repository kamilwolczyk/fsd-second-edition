namespace Fsd.Sebastian.Cs2.Animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override string SayHello()
        {
            return $"{base.SayHello()}, Hau Hau Hau.";
        }
    }
}
