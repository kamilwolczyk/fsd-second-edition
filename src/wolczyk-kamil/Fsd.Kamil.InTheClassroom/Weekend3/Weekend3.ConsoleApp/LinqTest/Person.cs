using System.Collections.Generic;

namespace Weekend3.ConsoleApp.LinqTest
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<BankAccount> Accounts { get; set; }
    }
}
