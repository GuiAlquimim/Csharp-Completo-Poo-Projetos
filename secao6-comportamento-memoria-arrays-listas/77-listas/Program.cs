using System.Collections.Generic;

namespace _77_listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> MyList1 = new List<string>();

            // Using Add()
            MyList1.Add("João");
            MyList1.Add("Biel");
            MyList1.Add("Bruno");
            MyList1.Add("Tiago");
            MyList1.Add("Marcos");
            MyList1.Add("Daniel");
            MyList1.Add("Marcelo");
            MyList1.Add("Maria");


            // Using Insert()
            MyList1.Insert(2, "Gui");

            foreach (string obj in MyList1)
            {
                Console.WriteLine(obj);
            }

            // Using Count()
            Console.WriteLine($"List count: {MyList1.Count()}");

            Console.WriteLine("--------------------------------");

            // Using Find() and FindLast() with lambda
            string f1 = MyList1.Find(x => x[0] == 'B');
            string f2 = MyList1.FindLast(x => x[0] == 'B');

            Console.WriteLine($"First 'B': {f1}");
            Console.WriteLine($"Last 'B': {f2}");

            Console.WriteLine("--------------------------------");

            // Using FindIndex() and FindLastIndex() with lambda
            int pos1 = MyList1.FindIndex(x => x[0] == 'B');
            int pos2 = MyList1.FindLastIndex(x => x[0] == 'B');

            Console.WriteLine($"First 'B' position: {pos1}");
            Console.WriteLine($"Last 'B' position: {pos2}");

            Console.WriteLine("--------------------------------");

            // Using FindAll() with lambda
            List<string> MyList2 = MyList1.FindAll(x => x.Length == 5);

            foreach (string obj in MyList2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------");

            // Using Remove(), RemoveAll(), RemoveAt() and RemoveRange() with lambda
            // MyList1.Remove("Daniel");
            // MyList1.RemoveAt(2);
            // MyList1.RemoveAll(x => x[0] == 'B');  
            MyList1.RemoveRange(2, 4);

            foreach (string obj in MyList1)
            {
                Console.WriteLine(obj);
            }



        }
    }
}