namespace _197_bloco_using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao13-trabalhando-com-arquivos\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
            }
        }
    }
}