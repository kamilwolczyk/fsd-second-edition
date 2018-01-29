namespace Fsd.Artur.Cs2.Animals
{
    public class Dog : Animal,INoise
    {
        public Dog(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{SayHello()}, Hau Hau Hau.";
        }
    }
}
