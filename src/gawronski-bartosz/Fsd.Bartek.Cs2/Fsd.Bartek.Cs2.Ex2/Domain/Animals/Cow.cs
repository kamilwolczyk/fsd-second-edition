using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class Cow : AnimalVoice
    {
        public string VoiceString { get; }

        public Cow(string name) : base(name)
        {
            VoiceString = "Muu Muuuu";
        }

        public override string Voice()
        {
            return $"{base.Voice()}, {VoiceString}";
        }
    }
}
