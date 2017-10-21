namespace Weekend2.Domain
{
    public class Boss : Employee
    {
        public Boss(string firstName, string lastName, int age, decimal salary)
            : base(firstName, lastName, age, salary)
            { }

        public override string SayHello()
        {
            return $"{HelloPrefix} jestem {FirstName} i jestem tu szefem";
        }
    }
}
