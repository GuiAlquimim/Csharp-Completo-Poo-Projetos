using System.Collections.Generic;

namespace _81_exercicio_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many lines? ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("How many columns? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            // Definindo valores da matriz:
            Console.WriteLine();
            for (int i = 0; i < m && i < n; i++)
            {
                if (i + 1 == 1) { Console.Write("1st line: "); }
                else if (i + 1 == 2) { Console.Write($"2nd line: "); }
                else if (i + 1 == 3) { Console.Write($"3rd line: "); }
                else { Console.Write($"{i + 1}th line: "); }

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            // Leitura da matriz:
            int line = 0;
            Console.WriteLine();
            for (int j = 0; j < n && line < m; j++)
            {
                Console.Write($"{mat[line, j]} ");

                if (j == n - 1)
                {
                    line++;
                    j = -1;
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.Write("Higlighted number: ");
            int hn = int.Parse(Console.ReadLine());

            // Posição e números próximos do número destacado:
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (hn == mat[i, j])
                    {
                        Console.WriteLine($"Position: {i},{j}");

                        if (j - 1 != -1)
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        else
                            Console.WriteLine("Left: None");

                        if (j + 1 < n)
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        else
                            Console.WriteLine("Right: None");

                        if (i - 1 != -1)
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        else
                            Console.WriteLine("Up: None");

                        if (i + 1 < m)
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        else
                            Console.WriteLine("Down: None");

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}