namespace Fsd.Maciej.Cs.Ex2
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string MakeSomeNoise { get; protected set; }

        public string AbautMe()
        {
            return $"Hello, my name is {Name}, {MakeSomeNoise}";
        }
    }
}