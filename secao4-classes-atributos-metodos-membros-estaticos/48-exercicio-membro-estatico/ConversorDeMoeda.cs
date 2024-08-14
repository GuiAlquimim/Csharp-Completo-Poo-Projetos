using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_exercicio_membro_estatico
{
    internal class ConversorDeMoeda
    {
        public static double ValorDolar(double a, double b)
        {
            double Iof = (a * b) / 100 * 6;
            return (a * b) + Iof ;
        }
    }
}
