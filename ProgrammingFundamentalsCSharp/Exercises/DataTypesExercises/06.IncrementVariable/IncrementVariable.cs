using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool overflow = number/256>0;
            Console.WriteLine(overflow?
                $"{number%256}\nOverflowed {number/256} times":
                $"{number%256}");           
        }
    }
}
