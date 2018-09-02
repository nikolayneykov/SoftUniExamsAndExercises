using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class PrintNumbersInIncreasingOrder
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            if (startNum + 4 > endNum)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i1 = startNum; i1 <= endNum - 4; i1++)
                    for (int i2 = startNum + 1; i2 <= endNum - 3; i2++)
                        for (int i3 = startNum + 2; i3 <= endNum - 2; i3++)
                            for (int i4 = startNum + 3; i4 <= endNum - 1; i4++)
                                for (int i5 = startNum + 4; i5 <= endNum; i5++)
                                {
                                    if (i1 < i2 && i2 < i3 && i3 < i4 && i4 < i5)
                                    {
                                        Console.WriteLine($"{i1} {i2} {i3} {i4} {i5}");
                                    }
                                }
            }

        }
    }
}
