using System;

namespace _91_datetime_propriedades_operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2004, 7, 26, 12, 50, 0);

            Console.WriteLine($"Original: {d}");
            Console.WriteLine();

            // Propriedades do DateTime

            Console.WriteLine($"1: Date: -{d.Date}-"); // Data SEM o horário
            Console.WriteLine($"2: Day: -{d.Day}-"); // DIA
            Console.WriteLine($"3: DayOfWeek: -{d.DayOfWeek}-"); // Dia da SEMANA (Monday no caso)
            Console.WriteLine($"4: DayOfYear: -{d.DayOfYear}-"); // Dia do ANO (208 no caso)
            Console.WriteLine($"5: Month: -{d.Month}-"); // Mês (7)
            Console.WriteLine($"6: Year: -{d.Year}-"); // Ano
            Console.WriteLine($"7: Kind: -{d.Kind}-"); // Tipo da data (Local / Universal)
            Console.WriteLine($"8: TimeOfDay: -{d.TimeOfDay}-"); // Horário completo
            Console.WriteLine($"9: Hour: -{d.Hour}-"); // Hora do dia
            Console.WriteLine($"10: Minute: -{d.Minute}-"); // Minutos
            Console.WriteLine($"11: Second: -{d.Second}-"); // Segundos
            Console.WriteLine($"12: Millisecond: -{d.Millisecond}-"); // Milisegundos           
            Console.WriteLine($"13: Ticks: -{d.Ticks}-"); // Quantidade de Ticks que representa a data

            Console.WriteLine("----------------------------------------------------");

            DateTime d2 = new DateTime(2004, 7, 26, 12, 50, 0);

            Console.WriteLine(d2.ToLongDateString()); // Data COMPLETA em string no formato local (segunda-feira, 26 de julho de 2004)
            Console.WriteLine(d2.ToShortDateString()); // Data RESUMIDA em string no formato local (26/07/2004)
            Console.WriteLine(d2.ToLongTimeString()); // Horário COMPLETO em string no formato local (12:50:00)
            Console.WriteLine(d2.ToShortTimeString()); // Horário RESUMIDO em string no formato local (12:50)
            Console.WriteLine(d2.ToString()); // Data e horário normal, no formato local (26/07/2004 12:50:00)
            Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss")); // Data e horário com formatação manual (2004-07-26 12:50:00)
            Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss.fff")); // Data e horário (com milisegundos) com formatação manual (2004-07-26 12:50:00.000)

            Console.WriteLine("----------------------------------------------------");

            DateTime d3 = new DateTime(2004, 7, 26);
            DateTime d4 = new DateTime(2004, 7, 29);

            TimeSpan t = d4.Subtract(d3);

            Console.WriteLine(t);
            Console.WriteLine(t.Days);
        }
    }
}