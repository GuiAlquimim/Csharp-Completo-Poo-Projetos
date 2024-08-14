using _230_introducao_delegates.Services;

namespace _230_introducao_delegates
{
    delegate double BynaryNumericOperation (double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BynaryNumericOperation bno = CalculationService.Sum;

            double result = bno(a, b);
            Console.WriteLine(result);
        }
    }
}