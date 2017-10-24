namespace Fsd.Sebastian.Cs2.Animals
{
    public interface IAnimal {  }
    public class Animal
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
