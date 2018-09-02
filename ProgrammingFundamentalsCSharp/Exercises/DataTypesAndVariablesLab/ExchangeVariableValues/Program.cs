using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Declare two integer variables a and b and assign them with 5 and 10 and after that 
             exchange their values by using some programming logic. 
             Print the variable values before and after the exchange.
             */
            int a = 5;
            int b = 10;
            Console.WriteLine("a={0} b={1}", a, b);
            a ^= b ^= a;
            b ^= a;
            Console.WriteLine("a={0} b={1}", a, b);
        }
    }
}
