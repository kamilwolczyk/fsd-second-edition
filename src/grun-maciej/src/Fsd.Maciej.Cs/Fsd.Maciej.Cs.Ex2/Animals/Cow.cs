namespace Fsd.Maciej.Cs.Ex2
{
    public class Cow : Animal
    {
        public override string Name { get; set; }

        public override string MakeSomeNoise()
        {
            return "Muu Muuuuu";
        }

        public override string AbautMe()
        {
            string whoAmI = $"{base.AbautMe()}{Name}, {MakeSomeNoise()}";
            return whoAmI;
        }
    }
}