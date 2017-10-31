using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            base.VoiceString = "Miauuuu";
        }

        public override string Voice()
        {
            return $"{base.Voice()}, {VoiceString}";
        }
    }
}
