using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_sobrecarga
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string a, double b, int c)
        {
            Nome = a;
            Preco = b;
            Quantidade = c;
        }

        public Produto(string a, double b) 
        {
            Nome = a;
            Preco = b;
        }

        public Produto() 
        { 

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