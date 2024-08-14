using _41_metodo_reaproveitamento_delegacao;
using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.Write("1: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("2: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("3: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Console.Write("1: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("2: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("3: ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

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