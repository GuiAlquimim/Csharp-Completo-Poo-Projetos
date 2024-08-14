namespace _92_timespan_propriedades_operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("----------------------------------------");

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine("Original: " + t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Total Days: " + t.TotalDays);
            Console.WriteLine("Total Hours: " + t.TotalHours);
            Console.WriteLine("Total Minutes: " + t.TotalMinutes);
            Console.WriteLine("Total Seconds: " + t.TotalSeconds);
            Console.WriteLine("Total Milliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("-----------------------------------------");

            TimeSpan tt1 = new TimeSpan(1,30,10);
            TimeSpan tt2 = new TimeSpan(0, 10, 5);

            Console.WriteLine($"tt1: {tt1}");
            Console.WriteLine($"tt2: {tt2}");
            Console.WriteLine();

            Console.WriteLine($"Add: {tt1.Add(tt2)}");
            Console.WriteLine($"Subtract: {tt1.Subtract(tt2)}");
            Console.WriteLine($"Multiply(2.0): {tt1.Multiply(2.0)}");
            Console.WriteLine($"Divide(2.0): {tt1.Divide(2.0)}");
        }
    }
}