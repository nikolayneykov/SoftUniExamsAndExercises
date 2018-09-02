using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            //top
            Console.WriteLine("@" + new string(' ', (width - 3) / 2) +
                "@" + new string(' ', (width - 3) / 2) + "@");
            Console.WriteLine("**" + new string(' ', (width - 5) / 2) +
                "*" + new string(' ', (width - 5) / 2) + "**");
            //mid
            for (int i = 1, midDot = 1; i < n / 2 - 1; i++, midDot += 2)
            {
                Console.WriteLine("*" + new string('.', i) + "*" +
                    new string(' ', (width - 6 - midDot - i * 2) / 2) +
                    "*" + new string('.', midDot) + "*" +
                     new string(' ', (width - 6 - midDot - i * 2) / 2) +
                     "*" + new string('.', i) + "*");
            }

            Console.WriteLine("*" + new string('.', n / 2 - 1) + "*"
                + new string('.', n - 3) +
                "*" + new string('.', n / 2 - 1) + "*");
            //bot
            Console.WriteLine("*" + new string('.', n / 2) + new string('*', (width - n - 3) / 2) + "." +
                new string('*', (width - n - 3) / 2) + new string('.', n / 2) + "*");
            Console.WriteLine(new string('*', width));
            Console.WriteLine(new string('*', width));

        }
    }
}
