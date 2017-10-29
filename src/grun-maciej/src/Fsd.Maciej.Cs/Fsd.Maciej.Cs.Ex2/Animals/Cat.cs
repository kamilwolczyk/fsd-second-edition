namespace Fsd.Maciej.Cs.Ex2
{
    public class Cat : Animal
    {
        public override string MakeSomeNois()
        {
            return "Miauuuuuuu";
        }

        public override string AbautMe()
        {
            string _whoAmI = $"{base.AbautMe()}{Name}, {MakeSomeNois()}";
            return _whoAmI;
        }
    }
}