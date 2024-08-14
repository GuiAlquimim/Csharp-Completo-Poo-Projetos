namespace _72_modificador_parametros_params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s1 = Calculator.Sum( 4, 5 );
            double s2 = Calculator.Sum( 4.5, 9 );

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}