using System;
using System.IO;
using System.Collections.Generic;

namespace _199_directory_directoryinfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\guigu\source\repos\csharp-completo-poo-projetos\secao13-trabalhando-com-arquivos\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occured.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}