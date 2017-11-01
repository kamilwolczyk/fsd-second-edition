namespace Fsd.Maciej.Cs.Ex2
{
    public class Sheep : Animal
    {
        public override string Name { get; set; }

        public override string MakeSomeNoise()
        {
            return "Bee Bee Bee";
        }

        public override string AbautMe()
        {
            string whoAmI = $"{base.AbautMe()}{Name}, {MakeSomeNoise()}";
            return whoAmI;
        }
    }
}