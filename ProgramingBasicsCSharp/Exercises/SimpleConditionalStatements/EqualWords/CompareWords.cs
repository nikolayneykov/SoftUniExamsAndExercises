using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class CompareWords
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord= Console.ReadLine().ToLower();
            Console.WriteLine(firstWord.Equals(secondWord)?"yes":"no");
        }
    }
}
