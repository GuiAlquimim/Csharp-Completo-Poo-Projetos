using _137_sobreposicao_virtual_override_base.Entities;

namespace _137_sobreposicao_virtual_override_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500.00);
            Account sacc = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc.Withdraw(10.0);
            sacc.Withdraw(10.0);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(sacc.Balance);
        }
    }
}