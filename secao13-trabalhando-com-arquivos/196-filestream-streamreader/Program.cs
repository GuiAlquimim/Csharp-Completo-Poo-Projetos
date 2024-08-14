using System;
using System.IO;

namespace _196_filestream_streamreader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao13-trabalhando-com-arquivos\file1.txt";
            // FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                // if (fs != null) fs.Close();
            }
        }
    }
}