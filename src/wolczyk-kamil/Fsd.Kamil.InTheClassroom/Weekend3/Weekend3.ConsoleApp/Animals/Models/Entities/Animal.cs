namespace Weekend3.ConsoleApp.Animals.Models.Entities
{
    public abstract class Animal : IIntroduction
    {
        private readonly string _name;
        private readonly string _voice;

        protected Animal(string name, string voice = "")
        {
            _name = name;
            _voice = voice;
        }

        public string SayHello()
        {
            return $"Hello, my name is {_name}, {_voice}";
        }
    }
}
