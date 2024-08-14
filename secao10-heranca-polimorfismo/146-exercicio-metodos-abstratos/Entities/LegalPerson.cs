using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _146_exercicio_metodos_abstratos.Entities
{
    internal class LegalPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TotalTax()
        {
            double tax;
            if (NumberOfEmployees > 10)
            {
                tax = AnnualIncome * 14 / 100;
            }
            else
            {
                tax = AnnualIncome * 16 / 100;
            }
            return tax;
        }
    }
}
