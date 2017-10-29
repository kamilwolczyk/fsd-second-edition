namespace Fsd.Maciej.Cs.Ex2
{
    public class Sheep : Animal
    {
        public override string MakeSomeNois()
        {
            return "Bee Bee Bee";
        }

        public override string AbautMe()
        {
            string _whoAmI = $"{base.AbautMe()}{Name}, {MakeSomeNois()}";
            return _whoAmI;
        }
    }
}