namespace _72_modificador_parametros_params
{
    internal class Calculator
    {
        public static double Sum(params double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];               
            }
            return sum;
        }
    }
}
