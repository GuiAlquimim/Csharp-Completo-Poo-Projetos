namespace _47_membros_estaticos_parte_2
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double CalcCircunferencia(double a)
        {
            return 2 * Pi * a;
        }

        public static double CalcVolume(double a)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(a, 3);
        }
    }
}
