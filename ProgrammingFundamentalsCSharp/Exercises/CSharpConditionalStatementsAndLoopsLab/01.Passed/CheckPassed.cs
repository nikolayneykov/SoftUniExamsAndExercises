using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Passed
{
    class CheckPassed
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
