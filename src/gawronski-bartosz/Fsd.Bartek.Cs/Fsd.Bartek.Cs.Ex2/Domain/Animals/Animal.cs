using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string VoiceString { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual string Voice()
        {
            return $"Hello, my name is {Name}";
        }
    }
}
