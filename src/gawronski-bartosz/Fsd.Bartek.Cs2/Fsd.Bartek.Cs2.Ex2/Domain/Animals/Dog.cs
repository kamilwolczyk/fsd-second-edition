using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class Dog : AnimalVoice
    {
        public string VoiceString { get; }

        public Dog(string name) : base(name)
        {
            VoiceString = "Hau hau hau";
        }

        public override string Voice()
        {
            return $"{base.Voice()}, {VoiceString}";
        }
    }
}
