using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DigitsWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string digitString = Console.ReadLine();
            int digitInt = 0;
            switch (digitString)
            {
                case "one":digitInt = 1;break;
                case "two":digitInt = 2;break;
                case "three":digitInt = 3;break;
                case "four":digitInt = 4; break;
                case "five":digitInt = 5;break;
                case "six":digitInt = 6;break;
                case "seven":digitInt = 7;break;
                case "eight":digitInt = 8;break;
                case "nine":digitInt = 9;break;
            }
            Console.WriteLine(digitInt);
        }
    }
}
