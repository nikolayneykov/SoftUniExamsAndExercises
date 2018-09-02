using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача6_Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxRows = n / 100 + (n/10) % 10;
            int maxCols = n / 100 + n%10;
            int digit1 = n / 100;
            int digit2 = (n / 10) % 10;
            int digit3 = n % 10;
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {                   
                    if (n%5==0)
                    {
                        n -= digit1;
                    }
                    else if (n%3==0)
                    {
                        n -= digit2;
                    }
                    else
                    {
                        n += digit3;
                    }
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
