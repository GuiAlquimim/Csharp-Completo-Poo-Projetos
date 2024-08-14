using System.Globalization;
using _215_restricoes_generics.Entities;
using _215_restricoes_generics.Services;

namespace _215_restricoes_generics.Entities
{
    internal class Product : IComparable
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

        public int CompareTo(object? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a Product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
