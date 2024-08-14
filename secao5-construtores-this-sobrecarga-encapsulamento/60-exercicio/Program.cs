using System;
using System.Globalization;

namespace _60_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb1;

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N)? ");
            char haveraDeposito = char.Parse(Console.ReadLine());

            if (haveraDeposito == 's' || haveraDeposito == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb1 = new ContaBancaria(numeroConta, titularConta, saldoInicial);
            }
            else
            {
                cb1 = new ContaBancaria(numeroConta, titularConta);
            }

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{cb1}");
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantiaDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cb1.Deposito(quantiaDeposito);

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{cb1}");
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double quantiaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cb1.Saque(quantiaSaque);

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{cb1}");
        }
    }
}