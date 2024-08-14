using System.Globalization;

namespace _69_vetores_parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vetor[i];
            }

            double media = sum / n;

            Console.WriteLine($"Average height: {media.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}