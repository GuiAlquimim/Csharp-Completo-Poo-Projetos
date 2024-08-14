using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _43_object_e_tostring
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
            return $"{Nome}, ${Preco.ToString("f2", CultureInfo.InvariantCulture)}, {Quantidade} unidades. Valor total: {ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
