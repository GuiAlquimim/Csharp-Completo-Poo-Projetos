using System.Globalization;

namespace _56_properties
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            double Total = _preco * _quantidade;
            return Total;
        }

        public int AdicionarProdutos(int a)
        {
            return _quantidade += a;
        }

        public int RemoverProdutos(int a)
        {
            return _quantidade -= a;
        }

        public override string ToString()
        {
            return $"{_nome}, ${_preco.ToString("f2", CultureInfo.InvariantCulture)}, {_quantidade} unidades. Valor total: ${ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
