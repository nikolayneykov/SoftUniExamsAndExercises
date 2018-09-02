using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double score = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int pInvalid = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 50)
                {
                    if (number >= 0 && number <= 9)
                    {
                        score += number * 0.2;
                        p1++;
                    }
                    else if (number >= 10 && number <= 19)
                    {
                        score += number * 0.3;
                        p2++;
                    }
                    else if (number >= 20 && number <= 29)
                    {
                        score += number * 0.4;
                        p3++;
                    }
                    else if (number >= 30 && number <= 39)
                    {
                        score += 50;
                        p4++;
                    }
                    else
                    {
                        score += 100;
                        p5++;
                    }
                }
                else
                {
                    score /= 2;
                    pInvalid++;
                }
            }

            Console.WriteLine("{0:F2}", score);
            Console.WriteLine("From 0 to 9: {0:F2}%", p1 / (double)n * 100);
            Console.WriteLine("From 10 to 19: {0:F2}%", p2 / (double)n * 100);
            Console.WriteLine("From 20 to 29: {0:F2}%", p3 / (double)n * 100);
            Console.WriteLine("From 30 to 39: {0:F2}%", p4 / (double)n * 100);
            Console.WriteLine("From 40 to 50: {0:F2}%", p5 / (double)n * 100);
            Console.WriteLine("Invalid numbers: {0:F2}%", pInvalid / (double)n * 100);
        }
    }
}
