using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 5;
            int dotCount = n;
            int row = 1;
            //top
            while (dotCount <2 * n + 1)
            {
                if (row <= n / 2)
                {
                    Console.WriteLine(new string('.', dotCount) +
                          new string('#', width - 2 * dotCount) +
                                      new string('.', dotCount));
                }
                else
                {
                    Console.WriteLine(new string('.', dotCount) + "#" +
                          new string('.', width - 2 * dotCount - 2) +
                                  "#" + new string('.', dotCount));
                }
                row++;
                dotCount++;
            }
            Console.WriteLine(new string('.', (width-n)/2) +
                          new string('#',n) +
                                      new string('.', (width-n)/2));

            //bot
            dotCount = (width - n) / 2-2;
            for (int i = 0; i < n + 2; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine(new string('.', (width - 10) / 2) +
                                                           "D^A^N^C^E^" +
                                       new string('.', (width - 10) / 2));
                }
                else
                {
                    Console.WriteLine(new string('.', dotCount) +
                          new string('#', width - 2 * dotCount) +
                                      new string('.', dotCount));
                }
            }
        }
    }
}
