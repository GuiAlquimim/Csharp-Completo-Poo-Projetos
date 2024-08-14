using System;
using System.Globalization;
using System.Collections.Generic;
using _143_classes_abstratas.Entities;

namespace _143_classes_abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Suponha q vc queira: Totalizar o saldo de todas as contas e sacar 10.00 de todas elas
            
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum1 = 0.0;
            foreach (Account acc in list)
            {
                sum1 += acc.Balance;
                Console.WriteLine(acc.Holder + " - " + acc.Balance);
            }

            Console.WriteLine("Total: " + sum1.ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            double sum2 = 0.0;
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
                sum2 += acc.Balance;
                Console.WriteLine(acc.Holder + " - " + acc.Balance);
            }

            Console.WriteLine("Total: " + sum2.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}