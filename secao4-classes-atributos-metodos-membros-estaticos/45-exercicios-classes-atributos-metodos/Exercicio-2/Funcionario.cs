using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio_2
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            return SalarioBruto += SalarioBruto / porcentagem;
        }

        public override string ToString()
        {
            return $"{Nome}, ${SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
