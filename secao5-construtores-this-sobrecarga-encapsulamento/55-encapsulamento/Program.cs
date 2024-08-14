using System;
using System.Globalization;

namespace _55_encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto("TV", 900.00, 10);

            p1.SetNome("TV 8K");

            Console.WriteLine(p1);
        }
    }
}