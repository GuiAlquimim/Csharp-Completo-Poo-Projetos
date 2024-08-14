namespace _73_modificadores_parametros_ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo com ref:

            int a = 5;
            Calculator.TripleA(ref a);

            Console.WriteLine(a);

            // Exemplo com out:

            int b = 10;
            int tripleB;

            Calculator.TripleB(10, out tripleB);

            Console.WriteLine(tripleB);
        }
    }
}