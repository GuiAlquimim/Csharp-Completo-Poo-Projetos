namespace _226_extension_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 10, 11, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}