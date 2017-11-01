namespace Fsd.Maciej.Cs.Ex2
{
    public class Dog : Animal
    {
        public override string Name { get; set; }

        public override string MakeSomeNoise()
        {
            return "Hau Hau Hau";
        }

        public override string AbautMe()
        {
            string whoAmI = $"{base.AbautMe()}{Name}, {MakeSomeNoise()}";
            return whoAmI;
        }
    }
}