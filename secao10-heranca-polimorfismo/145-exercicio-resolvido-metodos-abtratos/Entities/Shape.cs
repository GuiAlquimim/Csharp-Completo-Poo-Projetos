using System;
using _145_exercicio_resolvido_metodos_abtratos.Entities.Enums;

namespace _145_exercicio_resolvido_metodos_abtratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
