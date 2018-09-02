using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        }
    }
}
