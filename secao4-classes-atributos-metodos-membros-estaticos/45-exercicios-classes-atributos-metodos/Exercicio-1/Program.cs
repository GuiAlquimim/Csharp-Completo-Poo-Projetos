using System;
using System.Globalization;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo R1;

            R1 = new Retangulo();

            Console.WriteLine("Digite a largura e altura do retângulo:");
            
            Console.Write("Largura: ");
            R1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            R1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área = {R1.Area().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {R1.Perimetro().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {R1.Diagonal().ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}