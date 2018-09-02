using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Declare two string variables and assign them with Hello and World.
             Declare an object variable and assign it with the concatenation of the first two variables 
             (mind adding an interval between).
             Declare a third string variable and initialize it with the value of the object variable 
             (you should perform type casting).
             */

            string firstString = "Hello";
            string secondString = "World";
            object firstAndSecondStrings = firstString + " " + secondString;
            string thirdString = (string)firstAndSecondStrings;
            Console.WriteLine(thirdString);
        }
    }
}
