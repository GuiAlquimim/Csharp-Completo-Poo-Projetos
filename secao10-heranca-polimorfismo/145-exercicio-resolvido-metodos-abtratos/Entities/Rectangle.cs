using System;
using _145_exercicio_resolvido_metodos_abtratos.Entities.Enums;

namespace _145_exercicio_resolvido_metodos_abtratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
