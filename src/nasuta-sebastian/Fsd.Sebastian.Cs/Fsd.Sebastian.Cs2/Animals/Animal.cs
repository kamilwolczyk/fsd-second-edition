namespace Fsd.Sebastian.Cs2.Animals
{
    public class Animal : IAnimalPresenter
    {
        public string Name { get; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual string SayHello()
        {
            return $"Hello, my name is {Name}";
        }
    }
}
