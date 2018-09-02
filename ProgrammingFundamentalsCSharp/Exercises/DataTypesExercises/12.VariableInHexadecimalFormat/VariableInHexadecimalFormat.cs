using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            int hex = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(hex);
        }
    }
}
