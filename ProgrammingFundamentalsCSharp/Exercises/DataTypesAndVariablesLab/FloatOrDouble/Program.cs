using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Which of the following values can be assigned to a variable of type float 
             * and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
             *  Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/

            double firstNum = 34.567839023D;
            float secondNum = 12.345F;
            double thirdNum = 8923.1234857D;
            float fourthNum = 3456.091F;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", firstNum, secondNum, thirdNum, fourthNum);
        }
    }
}
