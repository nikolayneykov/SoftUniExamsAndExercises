using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05.ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;

            //top
            Console.WriteLine(new string('.', 2 * n - 1) + "/|\\" + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + "\\|/" + new string('.', 2 * n - 1));
            //mid
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine(new string('.', 2 * n - i - 1) + "*" +
                    new string('-', i) + "*" + new string('-', i) +
                    "*" + new string('.', 2 * n - i - 1));
            }
            //bot
            Console.WriteLine(new string('*', width));
            for (int i = 0; i < width; i++)
            {
                Console.Write(i % 2 == 0 ? '*' : '.');
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', width));
        }
    }
}
