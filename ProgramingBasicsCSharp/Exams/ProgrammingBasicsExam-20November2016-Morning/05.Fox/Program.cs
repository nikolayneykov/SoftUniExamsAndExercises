using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;
            //top
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i) + "\\" + 
                       new string('-', (width - 2) - 2 * i) + 
                                    '/' + new string('*', i));
            }
            //mid
            int midrows = n / 3;
            int sideStar = (width - 4 - n) / 2;
            int centerStar = n;
            for (int i = 0; i < midrows; i++)
            {
                Console.WriteLine("|"+new string('*',sideStar+i)+"\\"+
                                           new string('*',centerStar)+
                                   "/"+new string('*',sideStar+i)+"|");
                centerStar -= 2;
            }

            //bot
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('-', i) + "\\" + 
                       new string('*', (width - 2) - 2 * i) + 
                                    '/' + new string('-', i));
            }
        }
    }
}
