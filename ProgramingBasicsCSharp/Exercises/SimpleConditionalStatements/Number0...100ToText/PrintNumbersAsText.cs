using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0._._._100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            string[] zeroToNineteen = {"zero", "one", "two", "three", "four",
                                      "five", "six", "seven","eight", "nine",
                                      "ten", "eleven", "twelve", "thirteen",
                                        "fourteen",  "fifteen", "sixteen",
                                        "seventeen","eighteen","nineteen" };
            string[] decDigits = { "twenty", "thirty", "forty", "fifty",
                                    "sixty", "seventy", "eighty", "ninety" };
            if (number < 20 && number >= 0)
            {
                Console.WriteLine(zeroToNineteen[number]);
            }
            else if (number >= 20 && number < 100)
            {
                if (secondDigit != 0)
                {
                    Console.WriteLine(decDigits[firstDigit - 2] + " " + zeroToNineteen[secondDigit]);
                }
                else
                {
                    Console.WriteLine(decDigits[firstDigit - 2]);
                }

            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
