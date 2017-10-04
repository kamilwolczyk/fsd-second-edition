using System;

namespace Fsd.Kamil.Cs.Ex2.Animals
{
    public class Cow : Animal, ISound
    {
        public Cow(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{GetGreeting()}, Muu Muuu.";
        }
    }
}