using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class CalculateDNACombinations
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string elements = "OACGTX";

            for (int i1 = 1; i1 <= 4; i1++)
            {
                for (int i2 = 1; i2 <= 4; i2++)
                {
                    for (int i3 = 1; i3 <= 4; i3++)
                    {
                        if (i1 + i2 + i3 >= input)
                        {
                            Console.Write($"{elements[0]}{elements[i1]}{elements[i2]}{elements[i3]}{elements[0]} ");
                        }
                        else
                        {
                            Console.Write($"{elements[5]}{elements[i1]}{elements[i2]}{elements[i3]}{elements[5]} ");
                        }
                    }
                    Console.WriteLine();
                }
            }                
        }
    }
}
