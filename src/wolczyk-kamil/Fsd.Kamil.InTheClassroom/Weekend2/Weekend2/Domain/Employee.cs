namespace Weekend2.Domain
{
    public class Employee : Person
    {
        public decimal Salary { get; }

        public Employee(string firstName, string lastName, int age, decimal salary)
            : base(firstName, lastName, age)
        {
            Salary = salary;
            HelloPrefix = Age > 30 ? "Dzień dobry" : "Cześć";
        }

        public override string SayHello()
        {
            return $"{base.SayHello()}. Zarabiam {Salary}";
        }
    }
}