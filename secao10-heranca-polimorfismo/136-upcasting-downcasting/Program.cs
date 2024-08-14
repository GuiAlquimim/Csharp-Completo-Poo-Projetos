using _136_upcasting_downcasting.Entities;
using System;

namespace _136_upcasting_downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(8010, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(8020, "Maria", 0.0, 500.00);

            // UPCASTING
            Account acc1 = bacc;
            Console.WriteLine(acc1);

            Account acc2 = new BusinessAccount(1254, "Bob", 0.0, 500.00);
            Account acc3 = new SavingsAccount(6312, "Anna", 0.0, 0.01);

            // DOWNCASTING

            // BusinessAccount acc4 = acc2; (Errado, o compilador não sabe q acc2 é um BusinessAccount, mas um Account)
            BusinessAccount acc4 = (BusinessAccount)acc2;

            acc4.Loan(100.00);
            // acc2.Loan(200.00); Não funciona, o compilador acha que é do tipo Account

            // BusinessAccount acc5 = (BusinessAccount)acc3; O compilador não mostra mas dá erro, pois o SavingsAccount não tem relação com o BusinessAccount

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                Console.WriteLine("Business!");
            }
            else if (acc3 is SavingsAccount)
            {
                Console.WriteLine("Savings!");
            }

            BusinessAccount acc6 = acc3 as BusinessAccount;
        }
    }
}