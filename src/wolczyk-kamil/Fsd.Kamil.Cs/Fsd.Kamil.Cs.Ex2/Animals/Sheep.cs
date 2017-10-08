using System;

namespace Fsd.Kamil.Cs.Ex2.Animals
{
    public class Sheep : Animal, ISound
    {
        public Sheep(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{GetGreeting()}, Bee Bee Bee.";
        }
    }
}