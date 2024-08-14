using _208_exercicio_fixacao.Entites;
using _208_exercicio_fixacao.Services;

namespace _208_exercicio_fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}