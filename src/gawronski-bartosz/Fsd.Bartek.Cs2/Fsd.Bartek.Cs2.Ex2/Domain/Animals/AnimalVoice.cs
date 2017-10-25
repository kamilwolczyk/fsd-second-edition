using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class AnimalVoice : IAnimal
    {
        public string Name { get; set; }

        public AnimalVoice(string name)
        {
            Name = name;
        }

        public virtual string Voice()
        {
            return $"Hello, my name is {Name}";
        }
    }
}
