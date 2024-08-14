using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.Write("1: ");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("2: ");
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("3: ");
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Console.Write("1: ");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("2: ");
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("3: ");
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(pX * (pX-xA) * (pX-xB) * (pX-xC));
            
            double pY = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(pY * (pY-yA) * (pY-yB) * (pY-yC));

            Console.WriteLine($"Área de X = {areaX.ToString("f4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("f4", CultureInfo.InvariantCulture)}");

            double diferenca = 0;
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
                diferenca = (areaX - areaY);
            }
            else
            {
                Console.WriteLine("Maior área: Y");
                diferenca = (areaY - areaX);
            }

            Console.WriteLine($"Diferença de área = {diferenca.ToString("f4", CultureInfo.InvariantCulture)}");
        }
    }
}