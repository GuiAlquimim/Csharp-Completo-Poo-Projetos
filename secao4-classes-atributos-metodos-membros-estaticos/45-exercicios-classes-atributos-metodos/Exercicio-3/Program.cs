using System.Globalization;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno A1, A2;
            A1 = new Aluno();
            A2 = new Aluno();
            
            Console.Write("Nome do aluno: ");
            A1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");

            Console.Write("1: ");
            A1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("2: ");
            A1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("3: ");
            A1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota final: {A1.SomarNotas().ToString("f2", CultureInfo.InvariantCulture)}");

            if (A1.SomarNotas() >= 60)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram {60 - A1.SomarNotas()} pontos");
            }

            Console.Write("Nome do segundo aluno: ");
            A2.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");

            Console.Write("1: ");
            A2.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("2: ");
            A2.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("3: ");
            A2.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota final: {A2.SomarNotas().ToString("f2", CultureInfo.InvariantCulture)}");

            if (A2.SomarNotas() >= 60)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
                double Falta = 60 - A2.SomarNotas();
                Console.WriteLine($"Faltaram {Falta.ToString("f2", CultureInfo.InvariantCulture)} pontos");
            }
        }
    }
}