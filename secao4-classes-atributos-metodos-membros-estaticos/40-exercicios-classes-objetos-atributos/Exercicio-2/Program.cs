using _40_exercicios_classes_objetos_atributos;
using System;
using System.Globalization;

namespace _40_exercicios_classes_objetos_atributos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");

            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();

            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");

            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();

            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário médio: {Media2(f1.salario, f2.salario).ToString("f2", CultureInfo.InvariantCulture)}");
        }

        static double Media2(double x, double y)
        {
            double m = (x + y) / 2.0;
            return m;
        }
    }
}