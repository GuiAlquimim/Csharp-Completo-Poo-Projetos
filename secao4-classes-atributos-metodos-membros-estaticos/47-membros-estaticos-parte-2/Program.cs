using System;
using System.Globalization;

namespace _47_membros_estaticos_parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Circunferencia = Calculadora.CalcCircunferencia(Raio);
            double Volume = Calculadora.CalcVolume(Raio);

            Console.WriteLine($"Circunferência: {Circunferencia.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume {Volume.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de pi: {Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture)}");
        }

        

        
    }
}