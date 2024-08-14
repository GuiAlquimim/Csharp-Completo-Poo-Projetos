using System;
using System.Collections.Generic;
using System.Globalization;
using _141_exercicio_resolvido.Entities;

namespace _141_exercicio_resolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employe #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y' || outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }

                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("f2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}