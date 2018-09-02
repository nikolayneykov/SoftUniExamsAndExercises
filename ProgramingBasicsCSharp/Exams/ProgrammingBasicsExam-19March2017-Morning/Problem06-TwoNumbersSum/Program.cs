using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06_TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            bool foundMagic = false;
            int combinations = 0;

            for (int i = start; i >= end && !foundMagic; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    combinations++;
                    if (i + j == magic)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinations, i, j, magic);
                        foundMagic = true;
                        break;
                    }
                }
            }
            if (!foundMagic)
            {
                Console.WriteLine("{0} combinations - neither equals {1}",combinations,magic);
            }
        }
    }
}
