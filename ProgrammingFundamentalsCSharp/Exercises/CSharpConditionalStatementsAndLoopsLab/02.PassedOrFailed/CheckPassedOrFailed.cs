using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PassedOrFailed
{
    class CheckPassedOrFailed
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(grade < 3.00 ? "Failed!" : "Passed!");
        }
    }
}
