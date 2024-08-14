namespace _88_funcoes_para_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "    abcde FGHIJ ABC abc DEFG    ";

            string upper = original.ToUpper(); // Deixar tudo máiúsculo
            string lower = original.ToLower(); // Deixar tudo minúsculo
            string trim = original.Trim(); // Remover espaços vazios
            int inof = original.IndexOf("bc"); // Index da PRIMEIRA ocorrência do valor que vc quiser
            int lainof = original.LastIndexOf("bc"); // Index da ÚLTIMA ocorrência do valor que vc quiser
            string substr1 = original.Substring(10); // Pegar parte da string, no caso da 10 em diante
            string substr2 = original.Substring(10, 9); // Pegar parte da string, a partir do 10, com LIMITE de 9 caracteres
            string replace1 = original.Replace(' ', '_'); // Substituir o primeiro valor pelo segundo valor
            string replace2 = original.Replace("abc", "123"); // Mesma coisa mas com strings
            bool nullOrEmpty = string.IsNullOrEmpty(original); // Verificar se o valor é NULO ou VAZIO
            bool nullOrWhite = string.IsNullOrWhiteSpace(original); // Verificar se o valor é NULO ou apenas ESPAÇOS EM BRANCO

            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine();
            Console.WriteLine($"ToUpper: -{upper}-");
            Console.WriteLine($"Tolower: -{lower}-");
            Console.WriteLine($"Trim: -{trim}-");
            Console.WriteLine($"IndexOf(\"bc\"): -{inof}-");
            Console.WriteLine($"LastIndexOf(\"bc\"): -{lainof}-");
            Console.WriteLine($"Substring(8): -{substr1}-");
            Console.WriteLine($"Substring(10, 18): -{substr2}-");
            Console.WriteLine($"Replace(\" \", \"_\"): -{replace1}-");
            Console.WriteLine($"Replace(\"abc\", \"123\"): -{replace2}-");
            Console.WriteLine($"IsNullOrEmpty(original): -{nullOrEmpty}-");
            Console.WriteLine($"IsNullOrWhiteSpace(original): -{nullOrWhite}-");
        }
    }
}