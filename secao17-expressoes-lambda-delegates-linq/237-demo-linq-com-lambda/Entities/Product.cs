﻿using System.Globalization;

namespace _237_demo_linq_com_lambda.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product() { }

        public Product(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Price.ToString("f2", CultureInfo.InvariantCulture)}, {Category.Name}, {Category.Tier}";
        }
    }
}
