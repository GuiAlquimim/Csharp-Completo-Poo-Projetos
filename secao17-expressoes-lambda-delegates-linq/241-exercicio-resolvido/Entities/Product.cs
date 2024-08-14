using System.Globalization;

namespace _241_exercicio_resolvido.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
