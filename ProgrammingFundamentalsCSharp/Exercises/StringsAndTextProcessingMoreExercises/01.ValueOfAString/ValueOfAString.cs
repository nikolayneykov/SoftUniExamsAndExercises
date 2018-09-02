using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ValueOfAString
{
    class ValueOfAString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string caseToSearch = Console.ReadLine();
            int sum = 0;
            if (caseToSearch.Equals("LOWERCASE"))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char currentChar = input[i];
                    if (char.IsLetter(currentChar) && char.IsLower(currentChar))
                    {
                        sum += currentChar;
                    }
                }
            }
            else if (caseToSearch.Equals("UPPERCASE"))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char currentChar = input[i];
                    if (char.IsLetter(currentChar) && char.IsUpper(currentChar))
                    {
                        sum += currentChar;
                    }
                }
            }
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
