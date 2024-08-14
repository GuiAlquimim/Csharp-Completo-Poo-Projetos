using System.Globalization;

namespace _86_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numberbs to do the calculation.");

            Console.Write("1: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("2: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("What operation do you want to perform?");
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");

            int z = int.Parse(Console.ReadLine());

            Console.WriteLine();
            switch (z)
            {
                case 1:
                    Console.WriteLine($"Result: {x + y}");
                    break;

                case 2:
                    Console.WriteLine($"Result: {x - y}");
                    break;

                case 3:
                    Console.WriteLine($"Result: {x * y}");
                    break;

                case 4:
                    Console.WriteLine($"Result: {x / y}");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}