using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05_SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 12 * n - 5;
            int hashCounter = 1;
            //top
            for (int i = 0; i < n * 2; i++, hashCounter += 6)
            {
                Console.WriteLine(new string('.', (width - hashCounter) / 2) +
                                  new string('#', hashCounter) +
                                  new string('.', (width - hashCounter) / 2));
            }
            hashCounter -= 12;
            //mid
            for (int i = 0; i < n - 2; i++, hashCounter -= 6)
            {
                Console.WriteLine("|" + new string('.', ((width - hashCounter) - 1) / 2) +
                                  new string('#', hashCounter) +
                                  new string('.', (width - hashCounter) / 2));
            }
            //bot
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("|" + new string('.', ((width - hashCounter) - 1) / 2) +
                                  new string('#', hashCounter) +
                                  new string('.', (width - hashCounter) / 2));
            }
            Console.WriteLine("@" + new string('.', ((width - hashCounter) - 1) / 2) +
                                  new string('#', hashCounter) +
                                  new string('.', (width - hashCounter) / 2));
        }
    }
}
