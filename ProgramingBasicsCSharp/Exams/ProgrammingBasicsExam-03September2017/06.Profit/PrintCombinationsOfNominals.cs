using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class PrintCombinationsOfNominals
    {
        static void Main(string[] args)
        {
            int oneLevNumber = int.Parse(Console.ReadLine());
            int twoLevNumber = int.Parse(Console.ReadLine());
            int fiveLevNumber = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 <= oneLevNumber; i1++)
                for (int i2 = 0; i2 <= twoLevNumber; i2++)
                    for (int i3 = 0; i3 <= fiveLevNumber; i3++)
                    {
                        if (i1 * 1 + i2 * 2 + i3 * 5 == sum)
                        {
                            Console.WriteLine($"{i1} * 1 lv. + {i2} * 2 lv. + {i3} * 5 lv. = {sum} lv.");
                        }
                    }
        }
    }
}
