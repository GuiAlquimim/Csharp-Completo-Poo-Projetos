namespace _198_streamwriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string soucePath = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao13-trabalhando-com-arquivos\file1.txt";
            string targetPath = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao13-trabalhando-com-arquivos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(soucePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}