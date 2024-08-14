using System.Collections.Generic;
using System.IO;
using _241_exercicio_resolvido.Entities;
using System.Linq;
using System.Globalization;

namespace _241_exercicio_resolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao17-expressoes-lambda-delegates-linq\241-exercicio-resolvido\file.txt";
            Console.WriteLine("Full file path: " + path);

            List<Product> list = new List<Product>();

            try
            {
                Console.WriteLine();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        list.Add(new Product(name, price));
                    }
                }

                var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                var result = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name);

                Console.WriteLine("Average price: " + avg.ToString("f2", CultureInfo.InvariantCulture));
                foreach(Product p in result)
                {
                    Console.WriteLine(p.Name);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
            }
        }
    }
}