using System.Collections;
using System.Collections.Generic;

namespace _218_hashset_sortedset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Gui");
            set.Add("João");
            set.Add("Bruno");

            Console.WriteLine(set.Contains("João"));

            foreach (string obj in set)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------------------");

            SortedSet<int> a = new SortedSet<int>() { 0, 1, 2, 3, 4, 5 };
            SortedSet<int> b = new SortedSet<int>() {3, 4, 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);
            PrintCollection(b);

            // UnionWith - Junção (sem repetir) das coleçõoes (0 1 2 3 4 5 6 7 8 9 10)
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //Intersection - Itens que se repetem na coleção (3 4 5)
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //ExceptWith - Difereças da coleção (0 1 2)
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}