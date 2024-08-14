using System;
using System.Globalization;

namespace _137_sobreposicao_virtual_override_base.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }

        public override string ToString()
        {
            return $"Number: {Number}, Holder: {Holder}, Balance: {Balance.ToString("f2", CultureInfo.InvariantCulture)}, LoanLimit: {LoanLimit.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
