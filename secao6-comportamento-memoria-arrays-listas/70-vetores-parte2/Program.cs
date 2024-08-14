using System.Globalization;

namespace _70_vetores_parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos serão? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Product[] vetor = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nome do {i+1}º produto: ");
                string name = Console.ReadLine();

                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                vetor[i] = new Product(name, price);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vetor[i].Price;
            }

            double media = sum / n;

            Console.WriteLine($"Average price: {media.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}