using _215_restricoes_generics.Entities;
using _215_restricoes_generics.Services;
using System.Globalization;

namespace _215_restricoes_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("How many products? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                list.Add(new Product(name, price));
                Console.WriteLine();
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine($"Max: {max}");
        }
    }
}