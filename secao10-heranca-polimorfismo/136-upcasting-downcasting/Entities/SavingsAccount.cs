using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136_upcasting_downcasting.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override string ToString()
        {
            return $"Number: {Number}, Holder: {Holder}, Balance: {Balance.ToString("f2", CultureInfo.InvariantCulture)}, LoanLimit: {InterestRate.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
