using System;
using System.Globalization;

namespace _42_segundo_problema_exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1;

            p1 = new Produto();

            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p1.Nome}, ${p1.Preco.ToString("f2", CultureInfo.InvariantCulture)}, {p1.Quantidade} unidades, Total: ${p1.ValorTotalEmEstoque(p1.Preco, p1.Quantidade).ToString("f2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int AdicaoDeEstoque = int.Parse(Console.ReadLine());

            p1.AdicionarProdutos(AdicaoDeEstoque);

            Console.WriteLine($"Dados atualizados: {p1.Nome}, ${p1.Preco.ToString("f2", CultureInfo.InvariantCulture)}, {p1.Quantidade} unidades, Total: ${p1.ValorTotalEmEstoque(p1.Preco, p1.Quantidade).ToString("f2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int RemocaoDeEstoque = int.Parse(Console.ReadLine());

            p1.RemoverProdutos(RemocaoDeEstoque);

            Console.WriteLine($"Dados atualizados: {p1.Nome}, ${p1.Preco.ToString("f2", CultureInfo.InvariantCulture)}, {p1.Quantidade} unidades, Total: ${p1.ValorTotalEmEstoque(p1.Preco, p1.Quantidade).ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}