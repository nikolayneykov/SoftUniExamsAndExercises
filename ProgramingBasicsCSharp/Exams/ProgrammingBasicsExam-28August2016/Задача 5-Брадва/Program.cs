using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5_Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 5;
            //top to mid
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', n * 3) + 
                    "*" + new string('-', i) + "*"+
                    new string('-',width-n*3-i-2));
            }
            //mid
            int midHeight = n / 2;
            for (int i = 0; i < midHeight; i++)
            {
                Console.WriteLine(new string('*', n * 3) +
                    "*" + new string('-', n-1) + "*" +
                    new string('-', n-1));
            }
            //bot
            int botHeight =midHeight;
            for (int i = 0; i < botHeight; i++)
            {
                if (i<botHeight-1)
                {
                    Console.WriteLine(new string('-', n * 3 - i) +
                    "*" + new string('-', (n - 1) + i * 2) + "*" +
                    new string('-', n - 1-i));
                }
                else
                {
                    Console.WriteLine(new string('-', n * 3 - i) +
                    "*" + new string('*', (n - 1) + i * 2) + "*" +
                    new string('-', n - 1-i));
                }
            }
           
        }
    }
}
