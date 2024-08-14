using _221_exercicio.Entities;

namespace _221_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n1; i++)
            {
                Console.Write($"{i}: ");
                int registration = int.Parse(Console.ReadLine());
                students.Add(new Student(registration));
            }

            Console.WriteLine();
            Console.Write("How many students for course B? ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n2; i++)
            {
                Console.Write($"{i}: ");
                int registration = int.Parse(Console.ReadLine());
                students.Add(new Student(registration));
            }

            Console.WriteLine();
            Console.Write("How many students for course C? ");
            int n3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n3; i++)
            {
                Console.Write($"{i}: ");
                int registration = int.Parse(Console.ReadLine());
                students.Add(new Student(registration));
            }

            Console.WriteLine();
            Console.WriteLine("Total students: " + students.Count);
        }
    }
}