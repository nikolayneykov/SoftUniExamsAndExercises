using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class NumberCombinationsSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            bool findMatch = false;
            int combinationCounter = 0;
            int firstNumber = 0;
            int secondNumber = 0;

            for (int i = n; i <=m; i++)
            {
                for (int j = n; j <=m; j++)
                {
                    combinationCounter++;
                    if (i + j == magic)
                    {
                        findMatch = true;
                        firstNumber = i;
                        secondNumber = j;
                    }
                }
            }

            Console.WriteLine(findMatch ? 
                $"Number found! {firstNumber} + {secondNumber} = {magic}" :
                $"{combinationCounter} combinations - neither equals {magic}");
        }
    }
}
