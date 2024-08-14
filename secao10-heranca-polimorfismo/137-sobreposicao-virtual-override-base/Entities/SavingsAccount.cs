using System;
using System.Globalization;

namespace _137_sobreposicao_virtual_override_base.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /*public override void Withdraw(double amount)
        {
            Balance -= amount;
        }*/

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

        public override string ToString()
        {
            return $"Number: {Number}, Holder: {Holder}, Balance: {Balance.ToString("f2", CultureInfo.InvariantCulture)}, LoanLimit: {InterestRate.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
