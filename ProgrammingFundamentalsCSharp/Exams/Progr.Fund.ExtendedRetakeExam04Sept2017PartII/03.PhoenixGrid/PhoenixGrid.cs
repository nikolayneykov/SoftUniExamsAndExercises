using System;
using System.Text.RegularExpressions;

namespace _03.PhoenixGrid
{
    class PhoenixGrid
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "ReadMe")
            {
                Regex validationPattern = new Regex(@"^([^\s_]{3})(\.[^\s_]{3})*$");
                if (validationPattern.IsMatch(input))
                {
                    if (IsPalindrome(input))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        static bool IsPalindrome(string message)
        {
            int leftIndex = 0;
            int rightIndex = message.Length - 1;
            while (leftIndex < rightIndex)
            {
                if (message[leftIndex] != message[rightIndex])
                {
                    return false;
                }
                leftIndex++;
                rightIndex--;
            }
            return true;
        }
    }
}
