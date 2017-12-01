﻿namespace Fsd.Jacek.Cs.Ex2.Animals
{
    public class Cow : IAnimal
    {
        private string _name = string.Empty;

        public string Name { get { return _name; } set { _name = value; } }

        public string Voice { get { return "Mu!"; } }
    }
}
