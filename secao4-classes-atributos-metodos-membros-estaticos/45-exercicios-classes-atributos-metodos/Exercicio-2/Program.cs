using System;
using System.Globalization;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1;
            F1 = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário:");

            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            F1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            F1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Funcionário: {F1}");

            Console.Write("Digite a porcentagem de aumento de salário: ");
            double PorcentagemDeAumento = double.Parse(Console.ReadLine());
            Console.WriteLine();

            F1.AumentarSalario(PorcentagemDeAumento);

            Console.WriteLine($"Dados atualizados: {F1}");
        }
    }
}