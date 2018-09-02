using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case '+':result = num1 + num2;break;
                case '-':result = num1 - num2;break;
                case '*':result = num1 * num2;break;
                case '/':result = num1 / num2;break;
            }
            Console.WriteLine($"{num1} {action} {num2} = {result}");
        }
    }
}
