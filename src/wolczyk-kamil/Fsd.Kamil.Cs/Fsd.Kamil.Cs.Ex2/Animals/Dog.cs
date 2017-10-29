using System;

namespace Fsd.Kamil.Cs.Ex2.Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{GetGreeting()}, Hau Hau Hau.";
        }
    }
}