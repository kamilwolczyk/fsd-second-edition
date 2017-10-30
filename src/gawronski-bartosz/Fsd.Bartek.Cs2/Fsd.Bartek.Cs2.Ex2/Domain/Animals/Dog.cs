using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            base.VoiceString = "Hau hau hau";
        }

        public override string Voice()
        {
            return $"{base.Voice()}, {VoiceString}";
        }
    }
}
