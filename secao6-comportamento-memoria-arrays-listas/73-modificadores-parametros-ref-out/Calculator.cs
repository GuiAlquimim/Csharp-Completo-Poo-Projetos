using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_modificadores_parametros_ref_out
{
    internal class Calculator
    {
        public static void TripleA(ref int x)
        {
            x *= 3;
        }

        public static void TripleB(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
