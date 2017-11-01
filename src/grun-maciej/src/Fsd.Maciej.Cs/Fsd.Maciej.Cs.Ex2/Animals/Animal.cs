namespace Fsd.Maciej.Cs.Ex2
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract string MakeSomeNoise();

        public virtual string AbautMe()
        {
            return "Hello, my name is ";
        }
    }
}