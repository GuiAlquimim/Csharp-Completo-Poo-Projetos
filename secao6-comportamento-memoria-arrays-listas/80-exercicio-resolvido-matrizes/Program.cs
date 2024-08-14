namespace _80_exercicio_resolvido_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrix size: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int[,] mat = new int[n, n];

            int negativeNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                if (i + 1 == 1) { Console.Write("1st line: "); }
                else if (i + 1 == 2) { Console.Write($"2nd line: "); }
                else if (i + 1 == 3) { Console.Write($"3rd line: "); }
                else { Console.Write($"{i + 1}th line: "); }

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                    if (mat[i, j] < 0)
                    {
                        negativeNumbers++;
                    }
                }
            }
            Console.WriteLine();

            Console.Write("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mat[i, i]} ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"Negative numbers: {negativeNumbers}");

        }
    }
}