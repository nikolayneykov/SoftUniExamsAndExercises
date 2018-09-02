using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05_Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;

            //top
            Console.WriteLine(new string('*', width));
            Console.WriteLine(".*" + new string(' ', width - 4) + "*.");
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string('.', 2 + i) + "*" + 
                    new string('@', width - 6 - 2 * i) + 
                    "*" + new string('.', 2 + i));
            }
            //mid
            Console.WriteLine(new string('.', width / 2) + "*" + new string('.', width / 2));
            //bot
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string('.', n - 1 - i) + "*" + 
                    new string(' ', i) + "@" + new string(' ', i) + 
                    "*" + new string('.', n - 1 - i));
            }
            Console.WriteLine(".*"+new string('@',width-4)+"*.");
            Console.WriteLine(new string('*',width));
        }
    }
}
