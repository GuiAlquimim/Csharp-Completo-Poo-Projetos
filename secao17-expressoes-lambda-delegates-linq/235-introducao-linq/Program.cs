using System.Linq;

namespace _235_introducao_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // definir uma coleção
            int[] numbers = { 1, 2, 3, 4, 5, };

            // definir a consulta
            var result = numbers.Where(x => x % 2 != 0).Select(x => x * 10);

            // executar a consulta
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}