using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintRhombus(n);
        }
        static void PrintRhombus(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int spaceCount = n - i;
                int starCount = i;
                PrintLine(spaceCount,starCount);
            }
            for (int i = n - 1; i > 0; i--)
            {
                int spaceCount = n - i;
                int starCount = i;
                PrintLine(spaceCount,starCount);
            }
        }
        static void PrintLine(int spaceCount,int starCount)
        {
            for (int i = 0; i < spaceCount; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < starCount; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
