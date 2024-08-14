using System.Globalization;

namespace _136_upcasting_downcasting.Entities
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return $"Number: {Number}, Holder {Holder}, Balance{Balance.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
