using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class PrintLetterCombinations
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char avoid = char.Parse(Console.ReadLine());

            for (int i1 = start; i1 <= end; i1++)
                for (int i2 = start; i2 <= end; i2++)
                    for (int i3 = start; i3 <= end; i3++)
                    {
                        if (i1 != avoid && i2 != avoid && i3 != avoid)
                        {
                            Console.Write($"{(char)i1}{(char)i2}{(char)i3} ");
                        }
                    }
        }
    }
}
