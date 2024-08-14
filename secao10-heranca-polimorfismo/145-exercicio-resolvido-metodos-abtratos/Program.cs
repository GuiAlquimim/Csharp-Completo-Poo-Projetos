using System;
using System.Globalization;
using System.Collections.Generic;
using _145_exercicio_resolvido_metodos_abtratos.Entities;
using _145_exercicio_resolvido_metodos_abtratos.Entities.Enums;

namespace _145_exercicio_resolvido_metodos_abtratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}