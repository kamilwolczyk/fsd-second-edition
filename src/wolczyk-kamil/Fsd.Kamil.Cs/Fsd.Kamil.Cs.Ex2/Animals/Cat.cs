using System;

namespace Fsd.Kamil.Cs.Ex2.Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{GetGreeting()}, Miauuuu.";
        }
    }
}