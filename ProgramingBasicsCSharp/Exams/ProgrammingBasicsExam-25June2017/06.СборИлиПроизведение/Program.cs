using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.СборИлиПроизведение
{
    class Program
    {
        static void Main(string[] args)
        {
            int control = int.Parse(Console.ReadLine());
            bool found = false;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == control && a < b && b < c)
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, control);
                            found = true;
                        }
                        if (a * b * c == control && a > b && b > c)
                        {
                            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, control);
                            found = true;
                        }
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
