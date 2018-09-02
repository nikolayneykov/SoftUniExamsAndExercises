using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Snowflake
{
    class PrintSnowflake
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(new string('.', i) + "*" +
                                  new string('.', n - i) + "*" + new string('.', n - i) +
                                  "*" + new string('.', i));
            }
            //mid
            Console.WriteLine(new string('.', n - 1) + "*****" + new string('.', n - 1));
            Console.WriteLine(new string('*', 2 * n + 3));
            Console.WriteLine(new string('.', n - 1) + "*****" + new string('.', n - 1));
            //bot
            for (int i = n - 2; i >= 0; i--)
            {
                Console.WriteLine(new string('.', i) + "*" +
                                  new string('.', n - i) + "*" + new string('.', n - i) +
                                  "*" + new string('.', i));
            }
        }
    }
}
