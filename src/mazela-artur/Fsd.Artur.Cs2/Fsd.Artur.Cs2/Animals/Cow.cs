namespace Fsd.Artur.Cs2.Animals
{
    public class Cow : Animal, INoise
    {
        public Cow(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{SayHello()}, Muuu Muuu Muuu.";
        }
    }
}
