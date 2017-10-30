﻿using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public class Pig : Animal
    {
        public Pig(string name) : base(name)
        {
            base.VoiceString = "Chrum Chrum";
        }

        public override string Voice()
        {
            return $"{base.Voice()}, {VoiceString}";
        }
    }
}
