using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _146_exercicio_metodos_abstratos.Entities
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TotalTax();
    }
}
