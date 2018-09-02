using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string search = Console.ReadLine().ToLower();
            int currentIndex = text.IndexOf(search);
            int occurences = 0;
            while (currentIndex != -1)
            {
                currentIndex = text.IndexOf(search, currentIndex+1);
                occurences++;
            }
            Console.WriteLine(occurences);
        }
    }
}
