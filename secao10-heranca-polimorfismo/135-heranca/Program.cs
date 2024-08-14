using _135_heranca.Entities;

namespace _135_heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Guilherme Alquimim", 500.00, 200.00);

            // account.Balance = 100.00;  (protected)

            Console.WriteLine(account.Balance);
        }
    }
}