using System.Globalization;

namespace _48_exercicio_membro_estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação atual do dólar? ", CultureInfo.InvariantCulture);
            double CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);           

            Console.Write("Quantos dólares você deseja comprar? ", CultureInfo.InvariantCulture);
            double QuantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ValorTotal = ConversorDeMoeda.ValorDolar(CotacaoDolar, QuantidadeDolar);

            Console.WriteLine($"Valor a ser pago em reais = {ValorTotal.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}