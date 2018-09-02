using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 3;

            //top
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', ((width - 2) / 2) - i) + "/" +
                                  new string(' ', i * 2) +
                                  "\\" + new string('.', ((width - 2) / 2) - i));
            }
            Console.WriteLine(new string('.', n / 2) + 
                new string('*', width - n) + new string('.', n / 2));
            //mid
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine(new string('.', n / 2) +"|"+ 
                    new string('\\', width-2 - n)+
                    "|" + new string('.', n / 2));
            }
            //bot
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', (n / 2)-i) + "/" +
                    new string('*', (width - 2 - n)+i*2) +
                    "\\" + new string('.', (n / 2)-i));
            }
        }
    }
}
