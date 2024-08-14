using _211_interface_icomparable.Entities;
using System;

namespace _211_interface_icomparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao14-interfaces\file.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee line in list)
                    {
                        Console.WriteLine(line);
                    }
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