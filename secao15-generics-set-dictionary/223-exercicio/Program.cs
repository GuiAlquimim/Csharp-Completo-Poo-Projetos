namespace _223_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            Console.WriteLine();
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (dic.ContainsKey(name))
                            dic[name] += votes;
                        else dic.Add(name, votes);
                    }
                }

                foreach(KeyValuePair<string, int> kvp in dic)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("An error occured.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}