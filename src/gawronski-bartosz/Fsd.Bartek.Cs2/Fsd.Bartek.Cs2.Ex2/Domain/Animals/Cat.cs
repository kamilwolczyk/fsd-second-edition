using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class Cat : AnimalVoice
    {
        public string VoiceString { get;  }

        public Cat(string name) : base(name)
        {
            VoiceString = "Miauuuu";
        }

        public override string Voice()
        {
            return $"{base.Voice()}, {VoiceString}";
        }
    }
}
