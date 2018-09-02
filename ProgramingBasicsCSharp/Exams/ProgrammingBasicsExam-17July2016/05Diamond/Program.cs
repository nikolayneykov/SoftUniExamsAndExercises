using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int height = 3 * n + 2;

            //top
            Console.WriteLine(new string('.', n) + new string('*', width - 2 * n) + new string('.', n));
            //between top and mid
            for (int i = 0; i < n-1; i++)
            {
                int dotCount = n - 1 - i;
                Console.WriteLine(new string('.', dotCount) + "*" +
                                new string('.', (width - 2 * n) + i * 2) +
                                "*" + new string('.', dotCount));
            }
            //mid
            Console.WriteLine(new string('*', width));
            //between mid and bot
            int lowerHeight = height - n - 2;
            for (int i = 1; i <= lowerHeight; i++)
            {
                Console.WriteLine(new string('.', i) + "*" +
                    new string('.', width - 2 - i * 2) +
                    "*" + new string('.', i));
            }
            //bot

            Console.WriteLine(new string('.', (width - (n - 2)) / 2) +
                new string('*', n - 2) +
                new string('.', (width - (n - 2)) / 2));
        }
    }
}
