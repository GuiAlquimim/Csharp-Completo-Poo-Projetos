namespace _71_exercicio_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos[] array = new Alunos[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                array[room] = new Alunos(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Occupied rooms:");
            for (int i = 0; i < 10; i++)
            { 
                if (array[i] != null)
                {
                    Console.WriteLine($"{i}: {array[i]}");
                }
            }

        }
    }
}