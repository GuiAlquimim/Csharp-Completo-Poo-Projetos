using System;

namespace _90_timespan_representando_duracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O TimeSpan é uma duração/intervalo que vc define. Veja os formatos:

            TimeSpan t1 = new TimeSpan(0, 1, 30); // TimeSpan: Horas - Minutos - Segundos
            TimeSpan t2 = new TimeSpan(900000000L); // Mesma duração mas em Ticks
            TimeSpan t3 = new TimeSpan(10000000); // 1 segundo em Ticks (10.000.000 - Dez milhões)
            TimeSpan t4 = new TimeSpan(1, 2, 30, 50); // TimeSpan: Dia - Horas - Minutos - Segundos
            TimeSpan t5 = new TimeSpan(1, 2, 30, 50, 321); // TimeSpan: Dia - Horas - Minutos - Segundos - Milisegundos (321)

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine("---------------------------------------------");

            TimeSpan tf1 = TimeSpan.FromDays(1.5); // TimeSpan equivalente a 1.5 DIAS
            TimeSpan tf2 = TimeSpan.FromHours(2.5); // Equivalente a 2.5 HORAS
            TimeSpan tf3 = TimeSpan.FromMinutes(3.5); // Equivalente a 3.5 MINUTOS
            TimeSpan tf4 = TimeSpan.FromSeconds(4.5); // Equivalente a 4.5 SEGUNDOS
            TimeSpan tf5 = TimeSpan.FromMilliseconds(5.5); // Equivalente a 2.5 MILISEGUNDOS
            TimeSpan tf6 = TimeSpan.FromTicks(900000000L); // Ticks equivalente a 1.5 minutos (900 milhões de ticks).

            Console.WriteLine(tf1);
            Console.WriteLine(tf2);
            Console.WriteLine(tf3);
            Console.WriteLine(tf4);
            Console.WriteLine(tf5);
            Console.WriteLine(tf6);
        }
    }
}