using System;
using System.Globalization;

namespace _142_exercicio_heranca_polimorfismo.Entities
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

        public virtual string PriceTag()
        {
            return $"{Name} $ {Price.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
