using System.Globalization;

namespace _52_sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            string a = Console.ReadLine();

            Console.Write("Preço: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p1 = new Produto(a, b);

            Produto p2 = new Produto();

            Console.WriteLine($"Dados do produto: {p1}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int AdicaoDeEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine();

            p1.AdicionarProdutos(AdicaoDeEstoque);

            Console.WriteLine($"Dados atualizados: {p1}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int RemocaoDeEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine();

            p1.RemoverProdutos(RemocaoDeEstoque);

            Console.WriteLine($"Dados atualizados: {p1}");
        }
    }
}