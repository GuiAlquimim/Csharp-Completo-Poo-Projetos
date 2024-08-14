namespace _150_estrutura_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator!");
            Console.WriteLine();

            try
            {
                Console.Write("#1: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("#2: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            catch (FormatException)
            {
                Console.WriteLine("Please, enter two numbers to divide.");
            }
        }
    }
}