namespace _68_nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable <tipo> = 
            // tipo? = 
            // x.GetValueOrDefault() - Pegar o valor de X, senão o valor padrão do tipo do X
            // x.HasValue - Verificar se existe algum valor no X
            // x.Value - Pegar diretamente o valor de X, não funciona com Null
            // Operador de coalescência nula: ??
            // Exemplo: double y = x ?? 0.0;
            // Se X NÃO for Null, Y recebe o valor de X, senão Y recebe o valor após o "??"
            
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault()); // Vai imprimir "0" (Valor padrão do double)
            Console.WriteLine(y.GetValueOrDefault());
            
            Console.WriteLine();

            Console.WriteLine(x.HasValue); // Vai imprimir False
            Console.WriteLine(y.HasValue);
            
            Console.WriteLine();

            if (x.HasValue) Console.WriteLine(x.Value);
            else Console.WriteLine("X is null");

            if (y.HasValue) Console.WriteLine(y.Value);
            else Console.WriteLine("Y is null");
            
            Console.WriteLine();

            double? a = null;
            double b = a ?? 5;

            Console.WriteLine(b);
        }
    }
}