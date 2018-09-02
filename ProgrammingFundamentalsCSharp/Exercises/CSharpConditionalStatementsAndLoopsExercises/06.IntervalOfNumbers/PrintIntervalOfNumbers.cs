using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class PrintIntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int start = Math.Min(firstNumber, secondNumber);
            int end = Math.Max(firstNumber, secondNumber);
            for (int i = start; i <=end ; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
