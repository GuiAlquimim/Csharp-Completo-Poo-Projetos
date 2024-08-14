using System;
using System.Globalization;

namespace _89_datetime_representando_data_hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 10, 16); // Ano - Mês - Dia - Hora - Minuto - Segundo - Milisegundo (Com formatação específica)
            DateTime d2 = new DateTime(2022, 10, 16, 19, 0, 0, 500); // Ou coloca os 3 principais (ano, mes e dia), ou todos, com ou sem milisegundo.

            DateTime d3 = DateTime.Now; // Data E hoário atual
            DateTime d4 = DateTime.Today; // Data atual SEM o horário
            DateTime d5 = DateTime.UtcNow; // Data E horário atual em Greenwich

            Console.WriteLine($"Ticks: -{d1.Ticks}-");
            Console.WriteLine($"Data definida: -{d1}-");
            Console.WriteLine($"Data definida com horário: -{d2}-");
            Console.WriteLine($"Data e horário atual: -{d3}-");
            Console.WriteLine($"Data atual: -{d4}-");
            Console.WriteLine($"Data e hoário atual em greenwich: -{d5}-");

            Console.WriteLine("-------------------------------------------");

            DateTime p1 = DateTime.Parse("2004-07-26"); // Data em formato de string
            DateTime p2 = DateTime.Parse("2005-04-10 13:05:50"); // Data em formato de string com horário
            DateTime p3 = DateTime.Parse("20/01/2003"); // Agora com formato brasileiro (Recomendado seguir o formato dos bancos de dados)

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine("-------------------------------------------");

            DateTime pe1 = DateTime.ParseExact("1971-07-03", "yyyy-MM-dd", CultureInfo.InvariantCulture); // Data com formatação que vc quiser: formato - leitura do formato - format provider
            DateTime pe2 = DateTime.ParseExact("03/07/1971 15:30:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture); // Mesma coisa mas com um exemplo de data em formato brasileiro

            Console.WriteLine(pe1);
            Console.WriteLine(pe2);
        }
    }
}