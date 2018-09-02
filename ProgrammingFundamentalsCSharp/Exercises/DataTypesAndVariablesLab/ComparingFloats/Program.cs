using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double f = d - b;
            double c = b - d;
            if (f >= 0.000001)
            {
                Console.WriteLine("false");
            }
            else if (c >= 0.000001)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
