using System;
using System.IO;

namespace _195_file_fileinfo_ioexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao13-trabalhando-com-arquivos\file1.txt";
            string targetPath = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao13-trabalhando-com-arquivos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(Array.IndexOf(lines, line) + 1 + ": " + line);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
            }
        }
    }
}