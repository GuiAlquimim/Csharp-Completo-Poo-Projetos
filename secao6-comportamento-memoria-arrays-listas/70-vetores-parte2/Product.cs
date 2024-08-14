using System.Globalization;

namespace _70_vetores_parte2
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        { 
            Name = name;
            Price = price;
        }
    }
}
