﻿namespace Fsd.Maciej.Cs.Ex2
{
    public class Cat : Animal
    {
        public override string Name { get; set; }

        public override string MakeSomeNoise()
        {
            return "Miauuuuuuu";
        }

        public override string AbautMe()
        {
            string whoAmI = $"{base.AbautMe()}{Name}, {MakeSomeNoise()}";
            return whoAmI;
        }
    }
}