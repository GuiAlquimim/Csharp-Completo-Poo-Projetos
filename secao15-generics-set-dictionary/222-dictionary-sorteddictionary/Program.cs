using System.Collections.Generic;
using System;

namespace _222_dictionary_sorteddictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies.Add("name", "João");
            cookies.Add("email", "joao@gmail.com");
            cookies["phone"] = "19922222222";
            cookies["phone"] = "19900000000";
            // Somente sobreescreve quando adicionado dessa forma com colchetes, senão quebra.

            foreach (KeyValuePair<string, string> kvp in cookies)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine("Count: " + cookies.Count);

            Console.WriteLine("Phone key: " + cookies["phone"]);
            cookies.Remove("phone");
            
            if (cookies.ContainsKey("phone") == true)
                Console.WriteLine(cookies["phone"]);
            else Console.WriteLine("There isn't any key \"phone\"");
        }
    }
}