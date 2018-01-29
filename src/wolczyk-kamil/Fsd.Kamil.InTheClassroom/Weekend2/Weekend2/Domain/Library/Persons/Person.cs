using System;

namespace Weekend2.Domain.Library.Persons
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Person(string fullName, int age)
        {
            string[] names = fullName.Split(' ');

            if (names.Length != 2)
                throw new ArgumentException("fullName");

            FirstName = names[0];
            LastName = names[1];
            Age = age;
        }
    }
}
