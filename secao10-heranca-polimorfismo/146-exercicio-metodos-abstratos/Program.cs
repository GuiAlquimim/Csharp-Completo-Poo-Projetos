using System;
using System.Globalization;
using System.Collections.Generic;
using _146_exercicio_metodos_abstratos.Entities;

namespace _146_exercicio_metodos_abstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Natural or legal person (N/L)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'N' || ch == 'n')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new NaturalPerson(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
                }
                Console.WriteLine();
            }
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.0;
            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name}: $ {person.TotalTax().ToString("f2", CultureInfo.InvariantCulture)}");
                totalTaxes += person.TotalTax();
            }
            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {totalTaxes.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}