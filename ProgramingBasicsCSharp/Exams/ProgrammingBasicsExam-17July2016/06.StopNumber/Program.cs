using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i%2==0 && i%3==0)
                {
                    if (i==stop)
                    {
                        break;
                    }
                    Console.Write(i+" ");
                }
            }
        }
    }
}
