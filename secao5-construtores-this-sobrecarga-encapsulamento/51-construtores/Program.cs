using System.Globalization;

namespace _51_construtores
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

            Console.Write("Quantidade: ");
            double c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Produto p1 = new Produto("TV", 900.00, 10);

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