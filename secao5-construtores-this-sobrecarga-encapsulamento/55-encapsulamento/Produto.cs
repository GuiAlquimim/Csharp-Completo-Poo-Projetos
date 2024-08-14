using System.Globalization;

namespace _55_encapsulamento
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

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
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
