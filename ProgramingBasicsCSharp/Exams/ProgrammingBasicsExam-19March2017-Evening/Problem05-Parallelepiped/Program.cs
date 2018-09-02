using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05_Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 1;
            //top
            Console.WriteLine("+" + new string('~', n - 2) + "+" +
                new string('.', width - n));
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine("|" + new string('.', i) +
                    "\\" + new string('~', n - 2) + "\\" +
                    new string('.', width - n - 1 - i));
            }
            //bot
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine(new string('.', i) + "\\" +
                    new string('.', width - n - 1 - i) +
                    "|" + new string('~', n - 2) + "|");
            }
            Console.WriteLine(new string('.', width - n) + 
                "+" + new string('~', n - 2) + "+");
        }
    }
}
