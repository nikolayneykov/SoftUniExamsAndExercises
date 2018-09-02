using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progblem06_SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            bool magic = false;
            int combinationCount = 0;

            for (int i = startNum; i <= endNum && !magic; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    combinationCount++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})",
                            combinationCount, i, j, magicNum);
                        magic = true;
                        break;
                    }
                }
            }
            if (!magic)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinationCount, magicNum);
            }
        }
    }
}
