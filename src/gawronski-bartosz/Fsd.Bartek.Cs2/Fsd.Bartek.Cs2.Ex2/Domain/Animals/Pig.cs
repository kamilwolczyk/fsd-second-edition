using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class Pig : AnimalVoice
    {
        public string VoiceString { get; }

        public Pig(string name) : base(name)
        {
            VoiceString = "Chrum Chrum";
        }

        public override string Voice()
        {
            return $"{base.Voice()}, {VoiceString}";
        }
    }
}
