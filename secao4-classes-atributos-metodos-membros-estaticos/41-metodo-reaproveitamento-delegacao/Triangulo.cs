﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_metodo_reaproveitamento_delegacao
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p-A) * (p-B) * (p-C));
            return area;
        }
    }
}