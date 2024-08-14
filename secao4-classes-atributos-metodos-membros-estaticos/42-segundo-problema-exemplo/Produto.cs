using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _42_segundo_problema_exemplo
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(double a, double b)
        {
            double Total = a * b;
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
    }
}
