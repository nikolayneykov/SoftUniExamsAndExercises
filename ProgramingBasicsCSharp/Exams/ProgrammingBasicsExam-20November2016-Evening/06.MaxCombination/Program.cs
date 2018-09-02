using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            for (int i = start; i <=end && maxCombinations>=0; i++,maxCombinations--)
            {
                for (int j = start; j <= end && maxCombinations > 0; j++, maxCombinations--)
                {
                    Console.Write("<{0}-{1}>",i,j);
                }
            }
        }
    }
}
