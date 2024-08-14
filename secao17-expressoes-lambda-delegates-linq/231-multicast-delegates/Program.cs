using _231_multicast_delegates.Services;

namespace _231_multicast_delegates
{
    delegate void BynaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BynaryNumericOperation bno = CalculationService.ShowMax;
            bno += CalculationService.ShowSum;

            bno.Invoke(a, b);
        }
    }
}