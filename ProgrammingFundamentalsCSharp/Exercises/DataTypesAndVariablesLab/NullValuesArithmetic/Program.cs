using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("a={0}\nb={1}", a, b);
            a += 2;
            b += 3;
            Console.WriteLine("a={0}\nb={1}", a, b);
        }
    }
}
