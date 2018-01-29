namespace Weekend2.Domain.Work
{
    public class Employee : Person, IIdentification
    {
        public decimal Salary { get; }

        public string Id { get; }

        public Employee(string firstName, string lastName, int age, decimal salary)
            : base(firstName, lastName, age)
        {
            Salary = salary;
            HelloPrefix = Age > 30 ? "Dzień dobry" : "Hejka";
            Id = $"{firstName.ToLower()}-{lastName.ToLower()}";
        }

        public override string SayHello()
        {
            return $"{base.SayHello()}. Zarabiam {Salary}";
        }
    }
}