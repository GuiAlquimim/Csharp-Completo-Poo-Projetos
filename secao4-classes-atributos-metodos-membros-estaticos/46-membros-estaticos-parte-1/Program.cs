using System;
using System.Globalization;

namespace _46_membros_estaticos_parte_1
{
    internal class Program
    {
        static double Pi = 3.14;
        
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Circunferencia = CalcCircunferencia(Raio);
            double Volume = CalcVolume(Raio);

            Console.WriteLine($"Circunferência: {Circunferencia.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume {Volume.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de pi: {Pi.ToString("f2", CultureInfo.InvariantCulture)}");
        }

        static double CalcCircunferencia(double a)
        {
            return 2 * Pi * a;
        }

        static double CalcVolume(double a)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(a, 3);
        }
    }
}