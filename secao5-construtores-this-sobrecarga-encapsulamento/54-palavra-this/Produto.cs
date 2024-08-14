using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _54_palavra_this
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            double Total = Preco * Quantidade;
            return Total;
        }

        public int AdicionarProdutos(int a)
        {
            return Quantidade += a;
        }

        public int RemoverProdutos(int a)
        {
            return Quantidade -= a;
        }

        public override string ToString()
        {
            return $"{Nome}, ${Preco.ToString("f2", CultureInfo.InvariantCulture)}, {Quantidade} unidades. Valor total: ${ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
