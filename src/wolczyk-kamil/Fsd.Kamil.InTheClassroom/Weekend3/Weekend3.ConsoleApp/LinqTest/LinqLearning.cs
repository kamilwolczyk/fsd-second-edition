using System.Collections.Generic;
using System.Linq;

namespace Weekend3.ConsoleApp.LinqTest
{
    public class LinqLearning
    {
        private IEnumerable<int> _data;

        public LinqLearning()
        {
            _data = new List<int>
            {
                1, 2, 5, 6, 7, 8, 10
            };
        }

        public void Test()
        {
            //List<int> temp = new List<int>();

            //foreach (var number in _data)
            //{
            //    if (number > 5)
            //        temp.Add(number);
            //}

            //IEnumerable<float> result = from number in _data
            //                          where number > 5
            //                          select (float)2*number;

            //IEnumerable<float> result2 = _data
            //    .Select(number => (float)2*number)
            //    .Where(number => number > 5);

            foreach (var number in _data.OrderByDescending(x => x))
                System.Console.WriteLine(number);

            IEnumerable<Person> people = new List<Person>
            {
                new Person()
                {
                    FirstName = "Adam",
                    LastName = "Małysz",
                    Accounts = new List<BankAccount>
                    {
                        new BankAccount("1", 1240),
                        new BankAccount("2", 256),
                    }
                },
                new Person()
                {
                    FirstName = "Jan",
                    LastName = "Brzechwa",
                    Accounts = new List<BankAccount>
                    {
                    }
                },
                new Person()
                {
                    FirstName = "Jan",
                    LastName = "Brzechwa",
                    Accounts = new List<BankAccount>
                    {
                        new BankAccount("14", 6500),
                    }
                },
            };

            IEnumerable<string> richPeople = people
                .Where(person => person.Accounts.Any(account => account.CurrentState > 1000))
                .Select(person => person.LastName);
        }
    }
}
