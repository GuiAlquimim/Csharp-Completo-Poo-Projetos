using System;
using _145_exercicio_resolvido_metodos_abtratos.Entities.Enums;

namespace _145_exercicio_resolvido_metodos_abtratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
