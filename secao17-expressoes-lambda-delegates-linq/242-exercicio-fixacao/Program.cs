using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using _242_exercicio_fixacao.Entities;

namespace _242_exercicio_fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao17-expressoes-lambda-delegates-linq\242-exercicio-fixacao\file.txt";
            Console.WriteLine("Full file path: " + path);
            Console.WriteLine();

            Console.Write("Enter salary: ");
            double minSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] vect = sr.ReadLine().Split(',');
                        string name = vect[0];
                        string email = vect[1];
                        double salary = double.Parse(vect[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine($"Email of people whose salary is more than {minSalary.ToString("f2", CultureInfo.InvariantCulture)}:");

                var result = list.Where(p => p.Salary > minSalary).OrderBy(p => p.Email).Select(p => p.Email);
                var sum = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
                foreach (var emp in result)
                {
                    Console.WriteLine(emp);
                }
                Console.WriteLine();
                Console.Write($"Sum of salary of people whose name starts with 'M': {sum.ToString("f2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}