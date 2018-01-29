namespace Fsd.Artur.Cs2.Animals
{
    public class Pig : Animal,INoise
    {
        public Pig(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{SayHello()}, Chrum Chrum Chrum.";
        }
    }
}
