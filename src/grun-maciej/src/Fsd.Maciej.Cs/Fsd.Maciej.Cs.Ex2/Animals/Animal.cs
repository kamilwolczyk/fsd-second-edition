namespace Fsd.Maciej.Cs.Ex2
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract string MakeSomeNois();

        public virtual string AbautMe()
        {
            return "Hello, my name is ";
        }
    }
}