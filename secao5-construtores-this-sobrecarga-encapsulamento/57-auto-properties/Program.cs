namespace _57_auto_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto("TV", 900.00, 10);

            p1.Nome = "T";

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Quantidade);
        }
    }
}