using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FloatOrInteger
{
    class PrintFloatAsInteger
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            number = Math.Round(number);
            Console.WriteLine(number);
        }
    }
}
