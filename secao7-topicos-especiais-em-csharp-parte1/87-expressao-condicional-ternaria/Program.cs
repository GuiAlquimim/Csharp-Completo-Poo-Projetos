namespace _87_expressao_condicional_ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the bar!! \nSale is only allowed for adults.");
            
            Console.WriteLine();
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            string permition = (age > 18) ? "What would you like?" : "You can't drink yet.";
            
            Console.WriteLine(permition);
        }
    }
}