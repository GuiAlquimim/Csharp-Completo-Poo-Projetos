using System;

namespace _214_generics
{
    internal class PrintService<G>
    {
        private G[] vect = new G[10];
        private int count = 0;

        public void AddValue(G value)
        {
            if (count == 10)
            {
                throw new InvalidOperationException("PrintService is full.");
            }
            vect[count] = value;
            count++;
        }

        public G First()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("PrincService is empty");
            }
            return vect[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < count - 1; i++)
            {
                Console.Write($"{vect[i]}, ");
            }
            if (count > 0)
            {
                Console.WriteLine($"{vect[count - 1]}]");
            }

        }
    }
}
