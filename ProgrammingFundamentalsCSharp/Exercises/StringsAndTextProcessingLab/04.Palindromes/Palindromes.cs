using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> palindromes = new HashSet<string>();
            foreach (string word in input)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
        static bool IsPalindrome(string word)
        {
            bool palindrome = true;
            int leftIndex = 0;
            int rightIndex = word.Length - 1;
            while (leftIndex < rightIndex)
            {
                if (word[leftIndex] != word[rightIndex])
                {
                    return false;
                }
                leftIndex++;
                rightIndex--;
            }
            return palindrome;
        }
    }
}
