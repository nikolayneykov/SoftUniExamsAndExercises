using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            //top
            Console.WriteLine(new string('#', width));
            //mid
            int spaceCount = 1;
            int dotCount = 1;
            while(dotCount <= n)
            {
                if (dotCount == n / 2 + 1)
                {
                    Console.WriteLine(new string('.', dotCount) + new string('#', 2 * n - spaceCount) +
                        new string(' ', (spaceCount - 3) / 2) + "(@)" + new string(' ', (spaceCount - 3) / 2) +
                        new string('#', 2 * n - spaceCount) + new string('.', dotCount));
                }
                else
                {
                    Console.WriteLine(new string('.', dotCount) + new string('#', 2 * n - spaceCount) +
                        new string(' ', spaceCount) +
                        new string('#', 2 * n - spaceCount) + new string('.', dotCount));
                }
                dotCount++;
                spaceCount += 2;
            }
            //bot
            while (dotCount<=n*2)
            {
                spaceCount -= 2;
                Console.WriteLine(new string('.',dotCount)+new string('#',spaceCount)+new string('.',dotCount));
                dotCount++;              
            }
        }
    }
}
