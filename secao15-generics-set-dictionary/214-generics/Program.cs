namespace _214_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> p = new PrintService<int>();
            
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
    
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}: ");
                int value = int.Parse(Console.ReadLine());
                p.AddValue(value);
            }
            p.Print();
            Console.WriteLine($"First: {p.First()}");

            // int a = p.First();
            // int b = a + 2;
            // Console.WriteLine($"b: {b}");
        }
    }
}