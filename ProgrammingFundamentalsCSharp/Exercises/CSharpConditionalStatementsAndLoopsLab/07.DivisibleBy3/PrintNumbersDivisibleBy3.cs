using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.DivisibleBy3
{
    class PrintNumbersDivisibleBy3
    {
        static void Main(string[] args)
        {
            for (int i = 3; i < 100; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
