using System;
using System.Globalization;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many full numbers will you type?");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Valor {i}: ");
                int valorAtual = int.Parse(Console.ReadLine());
                sum += valorAtual;
            }

            Console.WriteLine($"Soma: {sum}");


        }

        static int Maior3(int a, int b, int c)
        {
            int m = 0;
            if (a > b && a > c)
            {
                 m = a;
            }
            else if (b > c)
            {
                 m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}