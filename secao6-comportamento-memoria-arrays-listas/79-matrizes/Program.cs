namespace _79_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            // Length - Quantos elementos no total
            Console.WriteLine(matriz.Length);

            // Rank - Quantos elementos têm na primeira dimensão da matriz (linhas)
            Console.WriteLine(matriz.Rank);

            // GetLength(0 or 1) - Quantos elementos na dimensão 0 (linhas) ou 1 (colunas)
            Console.WriteLine(matriz.GetLength(0));
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}