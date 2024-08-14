using _220_exercicio_resolvido.Entities;

namespace _220_exercicio_resolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> records = new HashSet<LogRecord>();

            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();
            Console.WriteLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string userName = line[0];
                        DateTime instante = DateTime.Parse(line[1]);
                        LogRecord lg = new LogRecord(userName, instante);
                        records.Add(lg);
                    }
                }
                Console.WriteLine($"Total users: {records.Count}");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}