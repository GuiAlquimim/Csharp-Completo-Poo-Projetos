    namespace _75_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "Maria", "José", "Fernando" };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("-----------------------------------------------");

            foreach (string x in array)
            {
                Console.WriteLine(x);
            }
        }
    }
}