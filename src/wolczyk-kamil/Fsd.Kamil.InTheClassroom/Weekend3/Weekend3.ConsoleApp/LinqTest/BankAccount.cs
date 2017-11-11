namespace Weekend3.ConsoleApp.LinqTest
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }

        public decimal CurrentState { get; set; }

        public BankAccount(string number, decimal money)
        {
            AccountNumber = number;
            CurrentState = money;
        }
    }
}
