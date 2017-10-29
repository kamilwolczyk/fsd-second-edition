namespace Fsd.Maciej.Cs.Ex2
{
    public class Cow : Animal
    {
        public override string MakeSomeNois()
        {
            return "Muu Muuuuu";
        }

        public override string AbautMe()
        {
            string _whoAmI = $"{base.AbautMe()}{Name}, {MakeSomeNois()}";
            return _whoAmI;
        }
    }
}