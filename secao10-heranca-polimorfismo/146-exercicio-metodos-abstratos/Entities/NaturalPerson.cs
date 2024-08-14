using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _146_exercicio_metodos_abstratos.Entities
{
    internal class NaturalPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public NaturalPerson(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {

            HealthExpenditures = healthExpenditures;
        }

        public override double TotalTax()
        {
            double tax;
            if (AnnualIncome < 20000.0)
            {
                tax = (AnnualIncome * 15 / 100) - (HealthExpenditures * 50 / 100);
            }
            else
            {
                tax = (AnnualIncome * 25 / 100) - (HealthExpenditures * 50 / 100);
            }
            return tax;
        }
    }
}
