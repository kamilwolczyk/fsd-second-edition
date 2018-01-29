namespace Weekend2.Domain.Work
{
    public class Person
    {
        protected string HelloPrefix { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HelloPrefix = "Cześć";
        }

        public virtual string SayHello()
        {
            return $"{HelloPrefix}, mam na imię {FirstName} {LastName} i mam {Age} lat";
        }
    }
}
