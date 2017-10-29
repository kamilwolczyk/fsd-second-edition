namespace Fsd.Maciej.Cs.Ex2
{
    public class Dog : Animal
    {
        public override string MakeSomeNois()
        {
            return "Hau Hau Hau";
        }

        public override string AbautMe()
        {
            string _whoAmI = $"{base.AbautMe()}{Name}, {MakeSomeNois()}";
            return _whoAmI;
        }
    }
}