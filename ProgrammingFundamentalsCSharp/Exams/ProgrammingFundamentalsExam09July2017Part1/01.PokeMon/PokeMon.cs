using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            decimal exhaustionNumber = n / 2.0m;
            long m = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());

            int count = 0;
            while (n >= m)
            {
                n -= m;
                count++;
                if (n == exhaustionNumber && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
