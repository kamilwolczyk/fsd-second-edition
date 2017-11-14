namespace Fsd.Jacek.Cs2.Animals
{
    public class Dog : IAnimal
    {
        private string _name = string.Empty;
        public string Name { get { return _name; } set { _name = value; } }

        public string Voice { get { return "Hau!"; } }
    }
}