namespace Fsd.Sebastian.Cs2.Animals
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name) { }

        public override string SayHello()
        {
            return $"{base.SayHello()}, Muu Muuu.";
        }
    }
}
