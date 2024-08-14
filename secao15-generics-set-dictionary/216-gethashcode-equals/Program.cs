using System;
using _216_gethashcode_equals.Entities;

namespace _216_gethashcode_equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b)); // Comparação de conteúdo (Email)
            Console.WriteLine(a == b); // Comparação da referência do obj
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}