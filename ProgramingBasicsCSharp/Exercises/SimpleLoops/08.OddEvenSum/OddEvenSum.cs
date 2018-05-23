using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSUm = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                evenSum += i % 2 == 0 ? number : 0;
                oddSUm += i % 2 == 1 ? number : 0;
            }
            if (oddSUm==evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSUm}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSUm-evenSum)}");
            }
        }
    }
}
