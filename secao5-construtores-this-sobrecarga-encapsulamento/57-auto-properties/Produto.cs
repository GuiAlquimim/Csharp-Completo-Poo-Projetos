using System.Globalization;

namespace _57_auto_properties
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return $"{_nome}, ${Preco.ToString("f2", CultureInfo.InvariantCulture)}, {Quantidade} unidades. Valor total: ${ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
