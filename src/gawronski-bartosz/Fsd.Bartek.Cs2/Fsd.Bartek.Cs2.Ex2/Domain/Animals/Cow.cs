using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name)
        {
            base.VoiceString = "Muu Muuuu";
        }

        public override string Voice()
        {
            return $"{base.Voice()}, {VoiceString}";
        }
    }
}
